using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotUserApiSupplier
{
    ValueTask<Result<BotUser, Failure<TelegramBotFailureCode>>> GetMeAsync(
        Unit input, CancellationToken cancellationToken);
}