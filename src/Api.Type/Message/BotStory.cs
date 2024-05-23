using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotStory
{
    [JsonConstructor]
    public BotStory(BotChat chat, int id)
    {
        Chat = chat;
        Id = id;
    }

    public BotChat Chat { get; }

    public int Id { get; }
}