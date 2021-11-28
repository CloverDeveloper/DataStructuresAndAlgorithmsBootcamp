using System;
using Arrays;
using Autofac;
using Common.Interface;
using Common.Model;
using TaskRunner.Container;
using TaskRunner.Model;

namespace TaskRunner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("選取執行課程: 1-10");

            var chapterType = Console.ReadLine();

            var container = AutofacContainer.Container();

            try 
            {
                var task = container.ResolveKeyed<ITask>(chapterType.ToEnum<ChapterType>());

                task.RunTask();
            }
            catch 
            {
                Console.WriteLine("執行失敗");
            }
        }
    }
}
