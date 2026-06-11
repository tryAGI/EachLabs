#nullable enable

using System.CommandLine;
using EachLabs.CLI;
using EachLabs.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the EachLabs SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(AIModelsApiGroupCommand.Create());
rootCommand.Subcommands.Add(AIModelsPredictionApiGroupCommand.Create());
rootCommand.Subcommands.Add(WebhooksApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);