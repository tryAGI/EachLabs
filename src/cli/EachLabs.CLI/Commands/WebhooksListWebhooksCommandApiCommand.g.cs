#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class WebhooksListWebhooksCommandApiCommand
{
    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of webhooks to return",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of webhooks to skip for pagination",
    };

                    private static string FormatResponse(ParseResult parseResult, global::EachLabs.ListWebhooksResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::EachLabs.ListWebhooksResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-webhooks", @"List webhooks
Retrieve a paginated list of webhooks for the authenticated organization");
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Webhooks.ListWebhooksAsync(
                                    limit: limit,
                                    offset: offset,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::EachLabs.SourceGenerationContext.Default,
                                        @"Webhooks",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::EachLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}