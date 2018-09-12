using System;
using System.Collections.Generic;
using System.Text;
using Housecool.Butterfly.OpenTracing;

namespace Housecool.Butterfly.Client.Tracing
{
    public static class LogFieldExtensions
    {
        public static LogField MethodExecuting(this LogField logField)
        {
            return logField?.Event("Method Executing");
        }

        public static LogField MethodExecuted(this LogField logField)
        {
            return logField?.Event("Method Executed");
        }
    }
}
