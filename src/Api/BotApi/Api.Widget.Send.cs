using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendWidgetAsync(
        BotWidgetSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new WidgetSendRequestJson
        {
            ChatId = input.ChatId,
            Html = input.Html,
            MessageThreadId = input.MessageThreadId,
            Width = input.Width,
            Height = input.Height,
            PublicData = input.PublicData,
            ChatData = input.ChatData,
            Caption = input.Caption,
            ParseMode = input.ParseMode,
            CaptionEntities = input.CaptionEntities,
            ShowCaptionAboveMedia = input.ShowCaptionAboveMedia,
            AllowQueries = input.AllowQueries,
            IsShared = input.IsShared,
            DisableNotification = input.DisableNotification,
            ProtectContent = input.ProtectContent,
            MessageEffectId = input.MessageEffectId,
            ReplyParameters = input.ReplyParameters,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<WidgetSendRequestJson, BotMessage>(request, cancellationToken);
    }
}
