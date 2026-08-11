using OpenTelemetry;
using OpenTelemetry.Trace;

namespace CSharpClassLibrary.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        private static TracerProvider _provider;

        public static void Initialize()
        {
            _provider = Sdk.CreateTracerProviderBuilder()
                .AddSource("CSharpClassLibrary")
                .AddConsoleExporter()
                .Build();
        }
    }
}
