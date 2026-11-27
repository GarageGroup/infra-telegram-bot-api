using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendRichMessageAsync(
        BotRichMessageSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new RichMessageSendRequestJson
        {
            ChatId = input.ChatId,
            RichMessage = input.RichMessage,
            BusinessConnectionId = input.BusinessConnectionId,
            MessageThreadId = input.MessageThreadId,
            DisableNotification = input.DisableNotification,
            ProtectContent = input.ProtectContent,
            MessageEffectId = input.MessageEffectId,
            ReplyParameters = input.ReplyParameters,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<RichMessageSendRequestJson, BotMessage>(request, cancellationToken);
    }
}
