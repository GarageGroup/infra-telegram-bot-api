using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct SharedWidgetDataEditRequestJson : IRequestJson<Unit>
{
    public static string BotMethod { get; } = "editSharedWidgetData";

    public required string WidgetId { get; init; }

    public required string PublicData { get; init; }

    public int? CacheTime { get; init; }
}
