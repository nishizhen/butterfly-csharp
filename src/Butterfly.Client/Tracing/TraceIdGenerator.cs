using Housecool.Butterfly.OpenTracing;

namespace Housecool.Butterfly.Client.Tracing
{
    public class TraceIdGenerator : ITraceIdGenerator
    {
        public string Next()
        {
            return RandomUtils.NextLong().ToString();
        }
    }
}
