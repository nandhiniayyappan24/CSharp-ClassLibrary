# CSharp Class Library — Monolithic (net10.0)

Class library monolithic project for **net10** targeting **.NET 10** (`net10.0`).

## Project type

- **Scenario:** 1 - Monolithic
- **Project type:** Class Library / NuGet Package
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
