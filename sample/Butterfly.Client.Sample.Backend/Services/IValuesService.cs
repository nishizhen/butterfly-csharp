using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Housecool.Butterfly.Client.Tracing;

namespace Housecool.Butterfly.Client.Sample.Backend.Services
{
    public interface IValuesService
    {
        [Trace]
        string[] GetValues();
    }
}
