using System;
using AspectCore.DynamicProxy;
using Housecool.Butterfly.DataContract.Tracing;

namespace Housecool.Butterfly.Client
{
    public interface IButterflyDispatcher : IDisposable
    {
        bool Dispatch(Span span);
    }
}