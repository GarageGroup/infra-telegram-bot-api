using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotUser, Failure<TelegramBotFailureCode>>> GetMeAsync(
        Unit input, CancellationToken cancellationToken)
        =>
        InnerSendOrFailureAsync<MeGetRequestJson, BotUser>(default, cancellationToken);
}