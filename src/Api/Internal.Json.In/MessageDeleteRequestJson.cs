using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct MessageDeleteRequestJson : IRequestJson<Unit>
{
    public static string BotMethod { get; } = "deleteMessage";

    public required long ChatId { get; init; }

    public required int MessageId { get; init; }
}