﻿using System;

namespace Housecool.Butterfly.Client.Benckmark.Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkDotNet.Running.BenchmarkRunner.Run<SerializationBenchmarks>();
        }
    }
}
