#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static class AIModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"ai-models", @"AI Models endpoint commands.");
                         command.Subcommands.Add(AiModelsGetModelCommandApiCommand.Create());
                         command.Subcommands.Add(AiModelsListModelsCommandApiCommand.Create());
        return command;
    }
}