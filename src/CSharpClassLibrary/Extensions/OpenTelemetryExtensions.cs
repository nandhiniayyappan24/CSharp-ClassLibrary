using System.Diagnostics;

namespace CSharpClassLibrary.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        public static void Initialize()
        {
            var source = new TraceSource("CSharpClassLibrary");
            source.TraceEvent(TraceEventType.Information, 0, "Class library telemetry bootstrap (net45)");
        }
    }
}
