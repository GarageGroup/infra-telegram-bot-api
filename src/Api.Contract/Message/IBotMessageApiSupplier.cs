using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotMessageApiSupplier
{
    ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendMessageAsync(
        BotMessageSendIn input, CancellationToken cancellationToken);

    ValueTask<Result<BotMessage?, Failure<TelegramBotFailureCode>>> EditTextMessageAsync(
        BotMessageTextEditIn input, CancellationToken cancellationToken);

    ValueTask<Result<BotMessage?, Failure<TelegramBotFailureCode>>> EditMessageReplyMarkupAsync(
        BotMessageReplyMarkupEditIn input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> DeleteMessageAsync(
        BotMessageDeleteIn input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> DeleteMessageSetAsync(
        BotMessageSetDeleteIn input, CancellationToken cancellationToken);

    ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendPhotoAsync(
        BotPhotoSendIn input, CancellationToken cancellationToken);
}