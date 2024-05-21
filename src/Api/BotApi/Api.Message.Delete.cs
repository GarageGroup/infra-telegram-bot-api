using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> DeleteMessageAsync(
        BotMessageDeleteIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageDeleteRequestJson
        {
            ChatId = input.ChatId,
            MessageId = input.MessageId
        };

        return InnerSendOrFailureAsync<MessageDeleteRequestJson, Unit>(request, cancellationToken);
    }
}