using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendMessageAsync(
        BotMessageSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageSendRequestJson
        {
            ChatId = input.ChatId,
            Text = input.Text,
            ParseMode = input.ParseMode,
            Entities= input.Entities,
            DisableWebPagePreview= input.DisableWebPagePreview,
            DisableNotification = input.DisableNotification,
            ProtectContent = input.ProtectContent,
            ReplyToMessageId = input.ReplyToMessageId,
            AllowSendingWithoutReply = input.AllowSendingWithoutReply,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<MessageSendRequestJson, BotMessage>(request, cancellationToken);
    }
}