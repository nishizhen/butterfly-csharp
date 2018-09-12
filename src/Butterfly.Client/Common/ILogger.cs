using System;
using AspectCore.DynamicProxy;

namespace Housecool.Butterfly.Client.Logging
{
    public interface ILogger
    {
        void Info(string message);

        void Error(string message, Exception exception);
    }
}
