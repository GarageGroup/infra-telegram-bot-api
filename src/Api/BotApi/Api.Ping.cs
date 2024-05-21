using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public async ValueTask<Result<Unit, Failure<Unit>>> PingAsync(Unit input, CancellationToken cancellationToken)
    {
        var result = await InnerSendOrFailureAsync<MeGetRequestJson, BotUser>(default, cancellationToken).ConfigureAwait(false);
        return result.Map(Unit.From, InnerMapFailure);

        static Failure<Unit> InnerMapFailure(Failure<TelegramBotFailureCode> failure)
            =>
            failure.WithFailureCode<Unit>(default);
    }
}