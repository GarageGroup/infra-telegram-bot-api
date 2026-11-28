using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct MessageWidgetDataEditRequestJson : IRequestJson<Unit>
{
    public static string BotMethod { get; } = "editMessageWidgetData";

    public long? ChatId { get; init; }

    public int? MessageId { get; init; }

    public string? InlineMessageId { get; init; }

    public string? PublicData { get; init; }

    public string? ChatData { get; init; }
}
