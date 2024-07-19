using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendPhotoAsync(
        BotPhotoSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new PhotoSendRequestJson
        {
            ChatId = input.ChatId,
            Photo = input.Photo,
            BusinessConnectionId = input.BusinessConnectionId,
            MessageThreadId = input.MessageThreadId,
            Caption = input.Caption,
            ParseMode = input.ParseMode,
            CaptionEntities = input.CaptionEntities,
            ShowCaptionAboveMedia = input.ShowCaptionAboveMedia,
            HasSpoiler = input.HasSpoiler,
            DisableNotification = input.DisableNotification,
            ProtectContent = input.ProtectContent,
            MessageEffectId = input.MessageEffectId,
            ReplyParameters = input.ReplyParameters,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<PhotoSendRequestJson, BotMessage>(request, cancellationToken);
    }
}