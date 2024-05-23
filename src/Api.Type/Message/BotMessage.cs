using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessage
{
    [JsonConstructor]
    public BotMessage(int messageId, DateTime date, BotChat chat)
    {
        MessageId = messageId;
        Date = date;
        Chat = chat;
    }

    public int MessageId { get; }

    public DateTime Date { get; }

    public BotChat Chat { get; }

    public int? MessageThreadId { get; init; }

    public BotUser? From { get; init; }

    public BotChat? SenderChat { get; init; }

    public int? SenderBoostCount { get; init; }

    public BotUser? SenderBusinessBot { get; init; }

    public string? BusinessConnectionId { get; init; }

    public BotMessageOriginBase? ForwardOrigin { get; init; }

    public bool? IsTopicMessage { get; init; }

    public bool? IsAutomaticForward { get; init; }

    public BotMessage? ReplyToMessage { get; init; }

    public BotExternalReplyInfo? ExternalReply { get; init; }

    public BotTextQuote? Quote { get; init; }

    public BotStory? ReplyToStory { get; init; }

    public BotUser? ViaBot { get; init; }

    public DateTime? EditDate { get; init; }

    public bool? HasProtectedContent { get; init; }

    public bool? IsFromOffline { get; init; }

    public string? MediaGroupId { get; init; }

    public string? AuthorSignature { get; init; }

    public string? Text { get; init; }

    public FlatArray<BotMessageEntity> Entities { get; init; }

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

    public string? Caption { get; init; }

    public FlatArray<BotMessageEntity> CaptionEntities { get; init; }

    public bool? HasMediaSpoiler { get; init; }

    public BotContact? Contact { get; init; }

    public BotDice? Dice { get; init; }

    public BotPoll? Poll { get; init; }

    public BotVenue? Venue { get; init; }

    public BotLocation? Location { get; init; }

    public FlatArray<BotUser> NewChatMembers { get; init; }

    public BotUser? LeftChatMember { get; init; }

    public string? NewChatTitle { get; init; }

    public FlatArray<BotPhotoSize> NewChatPhoto { get; init; }

    public bool? DeleteChatPhoto { get; init; }

    public bool? GroupChatCreated { get; init; }

    public bool? SupergroupChatCreated { get; init; }

    public bool? ChannelChatCreated { get; init; }

    public BotMessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; init; }

    public long? MigrateToChatId { get; init; }

    public long? MigrateFromChatId { get; init; }

    public BotMessage? PinnedMessage { get; init; }

    public BotInvoice? Invoice { get; init; }

    public BotSuccessfulPayment? SuccessfulPayment { get; init; }

    public BotUsersShared? UsersShared { get; init; }

    public BotChatShared? ChatShared  { get; init; }

    public string? ConnectedWebsite { get; init; }

    public bool? WriteAccessAllowed { get; init; }

    public BotPassportData? PassportData { get; init; }

    public BotProximityAlertTriggered? ProximityAlertTriggered { get; init; }

    public BotChatBoostAdded? BoostAdded { get; init; }

    public BotWebAppData? WebAppData { get; init; }

    public BotInlineKeyboardMarkup? ReplyMarkup { get; init; }
}