# CSharp Class Library — Monolithic (net48)

Class library monolithic project for **net48** targeting **.NET 48** (`net48`).

## Project type

- **Scenario:** 1 - Monolithic
- **Project type:** Class Library / NuGet Package (.NET Framework)
- **Language:** C#

## Supported tools

- AltCover
- Coverlet
- NuGet-Audit
- OpenTelemetry
- Roslyn
- Semgrep
- Stryker.NET
- jscpd
- lizard
- pydriller
- roslyn-sast

## Build

```bash
dotnet restore CSharpClassLibrary.sln
dotnet build CSharpClassLibrary.sln
dotnet test CSharpClassLibrary.sln
dotnet pack src/CSharpClassLibrary/CSharpClassLibrary.csproj
```

## Tool MSBuild targets

```bash
dotnet msbuild tools/CSharpClassLibrary.Tools/CSharpClassLibrary.Tools.csproj -t:RunCoverlet
dotnet msbuild tools/CSharpClassLibrary.Tools/CSharpClassLibrary.Tools.csproj -t:RunAltCover
```
