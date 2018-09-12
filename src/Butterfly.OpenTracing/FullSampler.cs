using Housecool.Butterfly.OpenTracing;

namespace Housecool.Butterfly.OpenTracing
{
    public class FullSampler : ISampler
    {
        public bool ShouldSample()
        {
            return true;
        }
    }
}