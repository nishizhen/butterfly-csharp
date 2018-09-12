namespace Housecool.Butterfly.Client.Tracing
{
    public interface ITraceIdGenerator
    {
        string Next();
    }
}