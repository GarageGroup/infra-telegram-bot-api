using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> DeleteMessageSetAsync(
        BotMessageSetDeleteIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new MessageSetDeleteRequestJson
        {
            ChatId = input.ChatId,
            MessageIds = input.MessageIds
        };

        return InnerSendOrFailureAsync<MessageSetDeleteRequestJson, Unit>(request, cancellationToken);
    }
}