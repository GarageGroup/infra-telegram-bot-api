using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<Unit, Failure<TelegramBotFailureCode>>> EditSharedWidgetDataAsync(
        BotSharedWidgetDataEditIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new SharedWidgetDataEditRequestJson
        {
            WidgetId = input.WidgetId,
            PublicData = input.PublicData,
            CacheTime = input.CacheTime
        };

        return InnerSendOrFailureAsync<SharedWidgetDataEditRequestJson, Unit>(request, cancellationToken);
    }
}
