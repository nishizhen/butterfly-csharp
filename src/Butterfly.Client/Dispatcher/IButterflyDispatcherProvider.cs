using System;
using System.Collections.Generic;
using System.Text;

namespace Housecool.Butterfly.Client
{
    public interface IButterflyDispatcherProvider
    {
        IButterflyDispatcher GetDispatcher();
    }
}
