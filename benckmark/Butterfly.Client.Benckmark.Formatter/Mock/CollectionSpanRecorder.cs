using System.Collections.Generic;
using System.Linq;
using Housecool.Butterfly.Client.Tracing;
using Housecool.Butterfly.OpenTracing;

namespace Housecool.Butterfly.Client.Benckmark.Formatter.Mock
{
    class CollectionSpanRecorder : ISpanRecorder
    {
        private ICollection<ISpan> collection = new List<ISpan>();

        public void Record(ISpan span)
        {
            collection.Add(span);
        }

        public ICollection<DataContract.Tracing.Span> GetSpans()
        {
            return collection.Select(x => SpanContractUtils.CreateFromSpan(x)).ToList();
        }
    }
}