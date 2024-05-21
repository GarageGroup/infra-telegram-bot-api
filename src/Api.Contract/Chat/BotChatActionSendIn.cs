namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotChatActionSendIn
{
    public BotChatActionSendIn(long chatId, BotChatAction action)
    {
        ChatId = chatId;
        Action = action;
    }

    public long ChatId { get; }

    public BotChatAction Action { get; }

    public string? BusinessConnectionId { get; init; }

    public string? MessageThreadId { get; init; }
}