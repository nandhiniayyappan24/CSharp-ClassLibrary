#!/usr/bin/env bash
set -euo pipefail
dotnet test ../../tests/CSharpClassLibrary.Tests/CSharpClassLibrary.Tests.csproj /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="xunit"
