using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotSharedWidgetDataEditIn
{
    public BotSharedWidgetDataEditIn(string widgetId, string publicData)
    {
        WidgetId = widgetId.OrEmpty();
        PublicData = publicData.OrEmpty();
    }

    public string WidgetId { get; }

    // The new public state of the widget, up to 1024 bytes; an empty state is removed
    public string PublicData { get; }

    // The time in seconds the public state may be cached by the apps, 5-3600
    public int? CacheTime { get; init; }
}
