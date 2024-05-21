using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed partial class BotApi(IHttpApi httpApi) : IBotApi
{
    private sealed record class BotRequest<TRequest>(HttpVerb HttpMethod, string BotMethod, TRequest? Request);

    private async ValueTask<Result<TOut, Failure<TelegramBotFailureCode>>> InnerSendOrFailureAsync<TRequest, TOut>(
        TRequest request, CancellationToken cancellationToken)
        where TRequest : IRequestJson<TOut>
    {
        var @in = new HttpSendIn(HttpVerb.Post, TRequest.BotMethod)
        {
            Body = HttpBody.SerializeAsJson(request, BotDefaultJson.SerializerOptions)
        };

        var result = await httpApi.SendAsync(@in, cancellationToken).ConfigureAwait(false);
        return result.Fold(FromSuccess, FromFailure);

        static Result<TOut, Failure<TelegramBotFailureCode>> FromSuccess(HttpSendOut success)
            =>
            ParseResponseOrFailure(success.Body);

        static Result<TOut, Failure<TelegramBotFailureCode>> FromFailure(HttpSendFailure failure)
        {
            if (failure.Body.Type.IsJsonMediaType(false) is false)
            {
                return failure.ToStandardFailure("An unexpected Telegram bot http failure occured:").WithFailureCode(TelegramBotFailureCode.Unknown);
            }

            return ParseResponseOrFailure(failure.Body);
        }

        static Result<TOut, Failure<TelegramBotFailureCode>> ParseResponseOrFailure(HttpBody body)
        {
            var response = body.DeserializeFromJson<ResponseJson<TOut>>(BotDefaultJson.SerializerOptions);

            if (response.Ok)
            {
                return DeserializeResult(response.Result)!;
            }

            if (string.IsNullOrWhiteSpace(response.Description))
            {
                return Failure.Create(response.ErrorCode.GetValueOrDefault(), $"An unexpected Telegram bot response: {body.Content}");
            }

            if (response.Parameters?.ExtensionData?.Count is not > 0)
            {
                return Failure.Create(response.ErrorCode.GetValueOrDefault(), response.Description);
            }

            var messageBuilder = new StringBuilder(response.Description).Append('.');
            foreach (var parameter in response.Parameters.ExtensionData)
            {
                _ = messageBuilder.Append(' ').Append(parameter.Key).Append(": ").Append(parameter.Value.ToString());
            }

            return Failure.Create(response.ErrorCode.GetValueOrDefault(), messageBuilder.ToString());
        }

        static TOut? DeserializeResult(JsonElement? result)
        {
            if (result is null || result.Value.ValueKind is JsonValueKind.Null or JsonValueKind.True)
            {
                return default;
            }

            return result.Value.Deserialize<TOut>(BotDefaultJson.SerializerOptions);
        }
    }
}