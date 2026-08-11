#!/usr/bin/env bash
set -euo pipefail
semgrep scan --config=p/csharp --error ../../src/CSharpClassLibrary/Analysis/SastFixture.cs
