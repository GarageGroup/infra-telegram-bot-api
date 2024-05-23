using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public readonly record struct BotChatBoostAdded
{
    [JsonConstructor]
    public BotChatBoostAdded(int boostCount)
        =>
        BoostCount = boostCount;

    public int BoostCount { get; }
}