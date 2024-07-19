using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotReplyParameters
{
    public BotReplyParameters(int messageId)
        =>
        MessageId = messageId;

    public int MessageId { get; }

    public long? ChatId { get; init; }

    public bool AllowSendingWithoutReply { get; init; }

    public string? Quote { get; init; }

    public BotParseMode QuoteParseMode { get; init; }

    public FlatArray<BotMessageEntity> QuoteEntities { get; init; }

    public int? QuotePosition { get; init; }
}