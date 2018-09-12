using System.Collections.Generic;

namespace Housecool.Butterfly.OpenTracing
{
    public interface ISpanContextFactory
    {
        ISpanContext Create(SpanContextPackage spanContextPackage);
    }
}