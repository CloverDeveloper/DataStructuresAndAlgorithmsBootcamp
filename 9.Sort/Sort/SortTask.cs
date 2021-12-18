using Common.Interface;
using System;

namespace Sort
{
    public class SortTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("SortTask");
        }
    }
}
