#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AIModelsApiGroupCommand.Create());
                         command.Subcommands.Add(AIModelsPredictionApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksApiGroupCommand.Create());
        return command;
    }
}