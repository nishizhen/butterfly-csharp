namespace Housecool.Butterfly.Client
{
    public interface IButterflySenderProvider
    {
        IButterflySender GetSender();
    }
}