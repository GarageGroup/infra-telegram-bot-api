using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> AnswerWidgetQueryAsync(
        BotWidgetQueryAnswerIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new WidgetQueryAnswerRequestJson
        {
            WidgetQueryId = input.WidgetQueryId,
            Data = input.Data
        };

        return InnerSendOrFailureAsync<WidgetQueryAnswerRequestJson, Unit>(request, cancellationToken);
    }
}
