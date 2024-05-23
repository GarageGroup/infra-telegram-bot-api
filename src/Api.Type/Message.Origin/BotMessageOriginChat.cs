using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageOriginChat : BotMessageOriginBase
{
    [JsonConstructor]
    public BotMessageOriginChat(BotChat senderChat, DateTime date) : base(BotMessageOriginType.Chat, date)
        =>
        SenderChat = senderChat;

    public BotChat SenderChat { get; }

    public string? AuthorSignature { get; init; }
}