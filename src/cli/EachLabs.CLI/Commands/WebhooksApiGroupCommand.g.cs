#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class WebhooksApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"webhooks", @"Webhooks endpoint commands.");
                         command.Subcommands.Add(WebhooksGetWebhookCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksListWebhooksCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}