﻿using Sixeyed.Extensions.Advanced.Demo1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Sixeyed.Extensions.Advanced.Tests.Demo1
{
    public static class InstrumentationExtensions
    {
        private static readonly Dictionary<Guid, Stopwatch> _stopwatches = new Dictionary<Guid, Stopwatch>();

        public static double GetPreciseElapsedTime(this Instrumentation instrumentation)
        {
            var fieldInfo =
                typeof(Instrumentation).GetField("_startedAt", BindingFlags.Instance | BindingFlags.NonPublic);
            var startedAt = (DateTime)fieldInfo.GetValue(instrumentation);
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }

        public static void StartWithPrecision(this Instrumentation instrumentation)
        {
            _stopwatches[instrumentation.Id] = Stopwatch.StartNew();
        }

        public static long GetReallyPreciseElapsedTime(this Instrumentation instrumentation)
        {
            return _stopwatches[instrumentation.Id].ElapsedMilliseconds;
        }
    }
}