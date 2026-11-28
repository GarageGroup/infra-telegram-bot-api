using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> EditMessageWidgetDataAsync(
        BotMessageWidgetDataEditIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageWidgetDataEditRequestJson
        {
            ChatId = input.ChatId,
            MessageId = input.MessageId,
            InlineMessageId = input.InlineMessageId,
            PublicData = input.PublicData,
            ChatData = input.ChatData
        };

        return InnerSendOrFailureAsync<MessageWidgetDataEditRequestJson, Unit>(request, cancellationToken);
    }
}
