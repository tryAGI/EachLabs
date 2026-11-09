#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from the each::labs Official API v1 spec
# embedded at https://api.eachlabs.ai/v1/docs.
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace EachLabs \
  --clientClassName EachLabsClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:X-API-Key \
  --output Generated \
  --reject-unknown-enum-values \
  --exclude-deprecated-operations

rm -rf ../../cli/EachLabs.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/EachLabs.CLI \
  --sdk-project ../../libs/EachLabs/EachLabs.csproj \
  --targetFramework net10.0 \
  --namespace EachLabs \
  --clientClassName EachLabsClient \
  --package-id EachLabs.CLI \
  --tool-command-name each-labs \
  --user-secrets-id EachLabs.CLI \
  --api-key-env-var EACHLABS_API_KEY \
  --base-url-env-var EACHLABS_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-Key
