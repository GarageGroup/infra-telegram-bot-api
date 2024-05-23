using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotChatShared
{
    [JsonConstructor]
    public BotChatShared(int requestId, long chatId)
    {
        RequestId = requestId;
        ChatId = chatId;
    }

    public int RequestId { get; }

    public long ChatId { get; }

    public string? Title { get; init; }

    public string? Username { get; init; }

    public FlatArray<BotPhotoSize> Photo { get; init; }
}