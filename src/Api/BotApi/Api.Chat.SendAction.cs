using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> SendChatActionAsync(
        BotChatActionSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new ChatActionSendRequestJson
        {
            ChatId = input.ChatId,
            Action = input.Action,
            BusinessConnectionId = input.BusinessConnectionId,
            MessageThreadId = input.MessageThreadId
        };

        return InnerSendOrFailureAsync<ChatActionSendRequestJson, Unit>(request, cancellationToken);
    }
}