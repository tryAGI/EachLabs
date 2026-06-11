#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static class WebhooksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhooks", @"Webhooks endpoint commands.");
                         command.Subcommands.Add(WebhooksGetWebhookCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksListWebhooksCommandApiCommand.Create());
        return command;
    }
}