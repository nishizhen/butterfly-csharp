using AspectCore.DynamicProxy;
using Housecool.Butterfly.OpenTracing;

namespace Housecool.Butterfly.Client.Tracing
{
    [NonAspect]
    public interface IServiceTracer
    {
        ITracer Tracer { get; }
        
        string ServiceName { get; }

        string Environment { get; }

        string Identity { get; }

        ISpan Start(ISpanBuilder spanBuilder);
    }
}