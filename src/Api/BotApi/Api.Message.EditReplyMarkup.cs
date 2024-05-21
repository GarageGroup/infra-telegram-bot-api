using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage?, Failure<TelegramBotFailureCode>>> EditMessageReplyMarkupAsync(
        BotMessageReplyMarkupEditIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageReplyMarkupEditRequestJson
        {
            ChatId = input.ChatId,
            MessageId = input.MessageId,
            InlineMessageId = input.InlineMessageId,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<MessageReplyMarkupEditRequestJson, BotMessage?>(request, cancellationToken);
    }
}