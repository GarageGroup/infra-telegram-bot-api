using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct ChatActionSendRequestJson : IRequestJson<Unit>
{
    public static HttpVerb HttpMethod
        =>
        HttpVerb.Post;

    public static string BotMethod
        =>
        "sendChatAction";

    public required long ChatId { get; init; }

    public required BotChatAction Action { get; init; }

    public string? BusinessConnectionId { get; init; }

    public string? MessageThreadId { get; init; }
}