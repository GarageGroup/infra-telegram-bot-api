using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotFileGetIn
{
    public BotFileGetIn(string fileId)
        =>
        FileId = fileId.OrEmpty();

    public string FileId { get; }
}