#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AIModelsApiGroupCommand.Create());
                         command.Subcommands.Add(AIModelsPredictionApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}