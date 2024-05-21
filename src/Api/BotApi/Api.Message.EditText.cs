using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage?, Failure<TelegramBotFailureCode>>> EditTextMessageAsync(
        BotMessageTextEditIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageTextEditRequestJson
        {
            ChatId = input.ChatId,
            MessageId = input.MessageId,
            InlineMessageId = input.InlineMessageId,
            Text = input.Text,
            ParseMode = input.ParseMode,
            Entities= input.Entities,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<MessageTextEditRequestJson, BotMessage?>(request, cancellationToken);
    }
}