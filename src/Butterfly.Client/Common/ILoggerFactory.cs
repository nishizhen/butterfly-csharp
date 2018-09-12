using System;
using AspectCore.DynamicProxy;

namespace Housecool.Butterfly.Client.Logging
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(Type type);
    }
}
