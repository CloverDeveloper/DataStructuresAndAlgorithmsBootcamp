using System;
using Arrays;
using Common.Model;
using TaskRunner.Model;

namespace TaskRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("選取執行課程: 1-10");

            var chapterType = Console.ReadLine();

            var task = TaskHelper.GetTask(chapterType.ToEnum<ChapterType>());

            task.RunTask();
        }
    }
}
