using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleTestBox.CountingTime
{
    public class CountingTimeObject : IDisposable
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private readonly string _title;
        private readonly int _times;
        public CountingTimeObject(string title,int times = 1)
        {
            _title = title;
            _times = times;
            _stopwatch.Start();
        }
        public void Dispose()
        {
            _stopwatch.Stop();
            Console.WriteLine($"{_title} : {_stopwatch.ElapsedTicks/_times}");
        }
    }
}
