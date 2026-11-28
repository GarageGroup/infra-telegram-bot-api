using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotMessage, Failure<TelegramBotFailureCode>>> SendSharedWidgetAsync(
        BotSharedWidgetSendIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new SharedWidgetSendRequestJson
        {
            ChatId = input.ChatId,
            WidgetId = input.WidgetId,
            MessageThreadId = input.MessageThreadId,
            ChatData = input.ChatData,
            Caption = input.Caption,
            ParseMode = input.ParseMode,
            CaptionEntities = input.CaptionEntities,
            ShowCaptionAboveMedia = input.ShowCaptionAboveMedia,
            DisableNotification = input.DisableNotification,
            ProtectContent = input.ProtectContent,
            MessageEffectId = input.MessageEffectId,
            ReplyParameters = input.ReplyParameters,
            ReplyMarkup = input.ReplyMarkup
        };

        return InnerSendOrFailureAsync<SharedWidgetSendRequestJson, BotMessage>(request, cancellationToken);
    }
}
