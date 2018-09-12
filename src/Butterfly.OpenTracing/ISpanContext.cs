using System;

namespace Housecool.Butterfly.OpenTracing
{
    public interface ISpanContext
    {
        string TraceId { get; }

        string SpanId { get; }

        bool Sampled { get; }

        Baggage Baggage { get; }
        
        SpanReferenceCollection References { get; }
    }
}