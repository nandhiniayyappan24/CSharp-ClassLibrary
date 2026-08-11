using OpenTelemetry;
using OpenTelemetry.Trace;

namespace CSharpClassLibrary.Extensions;

public static class OpenTelemetryBootstrap
{
    private static TracerProvider? _provider;

    public static void Initialize(string serviceName = "CSharpClassLibrary")
    {
        _provider = Sdk.CreateTracerProviderBuilder()
            .AddSource(serviceName)
            .AddConsoleExporter()
            .Build();
    }
}
