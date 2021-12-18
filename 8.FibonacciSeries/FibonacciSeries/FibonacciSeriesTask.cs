using Common.Interface;
using System;

namespace FibonacciSeries
{
    public class FibonacciSeriesTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("FibonacciSeriesTask");
        }
    }
}
