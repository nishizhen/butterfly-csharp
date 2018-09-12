using System;
using Housecool.Butterfly.OpenTracing;
using Microsoft.AspNetCore.Http;

namespace Housecool.Butterfly.Client.AspNetCore
{
    public interface IRequestTracer
    {

        ISpan OnBeginRequest(HttpContext httpContext);

        void OnEndRequest(HttpContext httpContext);

        void OnException(HttpContext httpContext, Exception exception, string @event);
    }
}