#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class AIModelsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"ai-models", @"AI Models endpoint commands.");
                         command.Subcommands.Add(AiModelsGetModelCommandApiCommand.Create());
                         command.Subcommands.Add(AiModelsListModelsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}