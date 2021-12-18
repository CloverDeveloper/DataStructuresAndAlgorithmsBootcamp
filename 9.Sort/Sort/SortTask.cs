using Common.Interface;
using Sort.Interface;
using Sort.Model;
using System;

namespace Sort
{
    public class SortTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("SortTask");
            int[] nums = new int[] { 8, 4, 7, 3, 6, 7, 8, 9, 2, 1, 5 };

            ISort merge = new MergeSort();

            nums = merge.Sort(nums);
        }
    }
}
