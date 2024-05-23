using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageOriginChannel : BotMessageOriginBase
{
    [JsonConstructor]
    public BotMessageOriginChannel(BotChat chat, int messageId, DateTime date) : base(BotMessageOriginType.Channel, date)
    {
        Chat = chat;
        MessageId = messageId;
    }

    public BotChat Chat { get; }

    public int MessageId { get; }

    public string? AuthorSignature { get; init; }
}