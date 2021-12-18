using Common.Interface;
using FibonacciSeries.Model;
using System;

namespace FibonacciSeries
{
    public class FibonacciSeriesTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("FibonacciSeriesTask - Start");

            Console.WriteLine("StripZero - Start");

            var recursion = new Recursion();

            Console.WriteLine("InputStr : ");

            var inputStr = Console.ReadLine();

            var res = recursion.StripZeros(inputStr);

            Console.WriteLine("StripZero - End");

            Console.WriteLine("Input Str is {0} ， Strip Res is {1}",inputStr,res);

            Console.WriteLine("FibonacciSeriesTask - End");
        }
    }
}
