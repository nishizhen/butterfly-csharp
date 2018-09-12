using System.Threading;
using System.Threading.Tasks;
using Butterfly.DataContract.Tracing;

namespace Housecool.Butterfly.Client
{
    public interface IButterflySender
    {
        Task SendSpanAsync(Span[] spans, CancellationToken cancellationToken = default(CancellationToken));
    }
}