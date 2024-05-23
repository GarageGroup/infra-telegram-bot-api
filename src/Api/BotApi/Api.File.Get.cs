using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Telegram.Bot;

partial class BotApi
{
    public ValueTask<Result<BotFile, Failure<TelegramBotFailureCode>>> GetFileAsync(
        BotFileGetIn input, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(input);

        var request = new FileGetRequest(input.FileId);
        return InnerSendOrFailureAsync<FileGetRequest, BotFile>(request, cancellationToken);
    }
}