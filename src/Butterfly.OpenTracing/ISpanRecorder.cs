using System.Threading.Tasks;

namespace Housecool.Butterfly.OpenTracing
{
    public interface ISpanRecorder
    {
        void Record(ISpan span);
    }
}