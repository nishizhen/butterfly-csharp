﻿using System.Threading.Tasks;

namespace Housecool.Butterfly.OpenTracing
{
    public interface ICarrierReader
    {
        ISpanContext Read(ICarrier carrier);

        Task<ISpanContext> ReadAsync(ICarrier carrier);
    }
}