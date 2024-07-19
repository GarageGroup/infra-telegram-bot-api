using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct MessageSetDeleteRequestJson : IRequestJson<Unit>
{
    public static string BotMethod { get; } = "deleteMessages";

    public required long ChatId { get; init; }

    public required FlatArray<int> MessageIds { get; init; }
}