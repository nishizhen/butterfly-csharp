using AspectCore.DynamicProxy;

namespace Housecool.Butterfly.Client.AspNetCore
{
    [NonAspect]
    public interface ITracingDiagnosticListener
    {
        string ListenerName { get; }
    }
}