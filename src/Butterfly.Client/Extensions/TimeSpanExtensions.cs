using System;

namespace Housecool.Butterfly.Client
{
    public static class TimeSpanExtensions
    {
        public static long GetMicroseconds(this TimeSpan timeSpan)
        {
            return timeSpan.Ticks / 10L;
        }
    }
}