namespace Housecool.Butterfly.OpenTracing
{
    public interface ISampler
    {
        bool ShouldSample();
    }
}