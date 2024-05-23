using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed record class FileGetRequest : IRequestJson<BotFile>
{
    public static string BotMethod { get; } = "getFile";

    public FileGetRequest(string fileId)
        =>
        FileId = fileId.OrEmpty();

    public string FileId { get; }
}