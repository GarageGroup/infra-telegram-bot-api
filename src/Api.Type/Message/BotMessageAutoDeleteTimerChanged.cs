using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageAutoDeleteTimerChanged
{
    [JsonConstructor]
    public BotMessageAutoDeleteTimerChanged(int messageAutoDeleteTime)
        =>
        MessageAutoDeleteTime = messageAutoDeleteTime;

    public int MessageAutoDeleteTime { get; }
}