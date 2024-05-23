using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotExternalReplyInfo
{
    [JsonConstructor]
    public BotExternalReplyInfo(BotMessageOriginBase origin)
        =>
        Origin = origin;

    public BotMessageOriginBase Origin { get; }

    public BotChat? Chat { get; init; }

    public int? MessageId { get; init; }

    public BotLinkPreviewOptions? LinkPreviewOptions { get; init; }

    public BotAnimation? Animation { get; init; }

    public BotAudio? Audio { get; init; }

    public BotDocument? Document { get; init; }

    public FlatArray<BotPhotoSize> Photo { get; init; }

    public BotSticker? Sticker { get; init; }

    public BotStory? Story { get; init; }

    public BotVideo? Video { get; init; }

    public BotVideoNote? VideoNote { get; init; }

    public BotVoice? Voice { get; init; }

    public bool? HasMediaSpoiler { get; init; }

    public BotContact? Contact { get; init; }

    public BotDice? Dice { get; init; }

    public BotInvoice? Invoice { get; init; }

    public BotLocation? Location  { get; init; }

    public BotPoll? Poll { get; init; }

    public BotVenue? Venue { get; init; }
}