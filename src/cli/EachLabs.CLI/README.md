# EachLabs.CLI

Command-line interface for the EachLabs SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global EachLabs.CLI --prerelease
```

## Usage

```bash
each-labs --help
each-labs ai-models --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
each-labs completion bash > /usr/local/etc/bash_completion.d/each-labs
each-labs completion zsh  > _each-labs   # then put it on your zsh fpath
each-labs completion fish > ~/.config/fish/completions/each-labs.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.