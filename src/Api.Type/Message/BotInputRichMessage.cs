using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotInputRichMessage
{
    public static BotInputRichMessage FromHtml(string html)
        =>
        new()
        {
            Html = html.OrEmpty()
        };

    public static BotInputRichMessage FromMarkdown(string markdown)
        =>
        new()
        {
            Markdown = markdown.OrEmpty()
        };

    private BotInputRichMessage()
    {
    }

    public string? Html { get; private init; }

    public string? Markdown { get; private init; }

    public bool? IsRtl { get; init; }

    public bool? SkipEntityDetection { get; init; }
}
