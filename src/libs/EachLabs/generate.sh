#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from the each::labs Official API v1 spec
# embedded at https://api.eachlabs.ai/v1/docs.

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace EachLabs \
  --clientClassName EachLabsClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:X-API-Key \
  --output Generated \
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
