using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotFile : BotFileBase
{
    [JsonConstructor]
    public BotFile(string fileId, string fileUniqueId, long? fileSize) : base(fileId, fileUniqueId, fileSize)
    {
    }

    public string? FilePath { get; init; }
}