#nullable enable

using System.CommandLine;

namespace EachLabs.CLI.Commands;

internal static partial class AIModelsPredictionApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"ai-models-prediction", @"AI Models Prediction endpoint commands.");
                         command.Subcommands.Add(AiModelsPredictionCreatePredictionCommandApiCommand.Create());
                         command.Subcommands.Add(AiModelsPredictionGetPredictionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}