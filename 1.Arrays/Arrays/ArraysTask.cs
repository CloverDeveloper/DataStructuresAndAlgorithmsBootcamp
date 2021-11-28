using System;
using Arrays.Model;
using Common.Interface;

namespace Arrays
{
    /// <summary>
    /// 課程一 Arrays 課程練習
    /// </summary>
    public class ArraysTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("ArraysTask");


            var arrays = new DynamicArray<string>(3);

            Console.WriteLine("ArraysTask - SetByIndex - Start"); 

            arrays.SetByIndex(0, "Hello");
            arrays.SetByIndex(1, "World");
            arrays.SetByIndex(2, "End");
            arrays.Print();

            Console.WriteLine("ArraysTask - SetByIndex - End");

            Console.WriteLine("ArraysTask - DeleteByIndex - Start");

            arrays.DeleteByIndex(1);
            arrays.Print();

            Console.WriteLine("ArraysTask - DeleteByIndex - End");

            Console.WriteLine("ArraysTask - InsertByIndex - Start");

            arrays.InsertByIndex(1, "World");
            arrays.Print();

            Console.WriteLine("ArraysTask - InsertByIndex - End");
        }
    }
}
