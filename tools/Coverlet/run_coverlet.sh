#!/usr/bin/env bash
set -euo pipefail
dotnet test ../../tests/CSharpClassLibrary.Tests/CSharpClassLibrary.Tests.csproj --collect:"XPlat Code Coverage"
