#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class WebhooksGetWebhookCommandApiCommand
{
    private static Argument<string> ExecutionId { get; } = new(
        name: @"execution-id")
    {
        Description = @"Execution ID for tracking the webhook",
    };

                    private static string FormatResponse(ParseResult parseResult, global::EachLabs.WebhookWithAttempts value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::EachLabs.WebhookWithAttempts value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-webhook", @"Get webhook by execution ID
Retrieve details of a specific webhook including delivery attempts by execution ID");
                        command.Arguments.Add(ExecutionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var executionId = parseResult.GetRequiredValue(ExecutionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Webhooks.GetWebhookAsync(
                                    executionId: executionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::EachLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}