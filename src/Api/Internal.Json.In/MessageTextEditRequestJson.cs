using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed record class MessageTextEditRequestJson : IRequestJson<BotMessage?>
{
    public static string BotMethod
        =>
        "editMessageText";

    public required long? ChatId { get; init; }

    public required int? MessageId { get; init; }

    public required string? InlineMessageId { get; init; }

    public required string Text { get; init; }

    public required BotParseMode ParseMode { get; init; }

    public required FlatArray<BotMessageEntity> Entities { get; init; }

    public required BotInlineKeyboardMarkup? ReplyMarkup { get; init; }
}