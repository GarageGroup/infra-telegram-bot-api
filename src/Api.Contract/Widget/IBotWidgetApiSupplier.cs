using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotWidgetApiSupplier
{
    ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendWidgetAsync(
        BotWidgetSendIn input, CancellationToken cancellationToken);

    ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendSharedWidgetAsync(
        BotSharedWidgetSendIn input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> AnswerWidgetQueryAsync(
        BotWidgetQueryAnswerIn input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> EditMessageWidgetDataAsync(
        BotMessageWidgetDataEditIn input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> EditSharedWidgetDataAsync(
        BotSharedWidgetDataEditIn input, CancellationToken cancellationToken);
}
