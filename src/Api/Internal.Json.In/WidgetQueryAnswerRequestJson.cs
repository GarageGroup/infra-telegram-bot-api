using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct WidgetQueryAnswerRequestJson : IRequestJson<Unit>
{
    public static string BotMethod { get; } = "answerWidgetQuery";

    public required string WidgetQueryId { get; init; }

    public string? Data { get; init; }
}
