namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageDeleteIn
{
    public BotMessageDeleteIn(long chatId, int messageId)
    {
        ChatId = chatId;
        MessageId = messageId;
    }

    public long ChatId { get; }

    public int MessageId { get; }
}