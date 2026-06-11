#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static class AIModelsPredictionApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"ai-models-prediction", @"AI Models Prediction endpoint commands.");
                         command.Subcommands.Add(AiModelsPredictionCreatePredictionCommandApiCommand.Create());
                         command.Subcommands.Add(AiModelsPredictionGetPredictionCommandApiCommand.Create());
        return command;
    }
}