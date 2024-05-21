using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotChatApiSupplier
{
    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> SendChatActionAsync(
        BotChatActionSendIn input, CancellationToken cancellationToken);
}