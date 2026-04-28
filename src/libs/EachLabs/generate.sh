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
