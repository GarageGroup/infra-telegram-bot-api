using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotFileGetSupplier
{
    ValueTask<Result<BotFile, Failure<TelegramBotFailureCode>>> GetFileAsync(
        BotFileGetIn input, CancellationToken cancellationToken);
}