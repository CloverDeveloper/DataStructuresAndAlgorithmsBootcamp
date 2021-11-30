using Common.Interface;
using LinkedList.Model;
using System;

namespace LinkedList
{
    public class LinkedListTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("LinkedListTask - Start");

            var linkedNodeList = new LinkedNodeList();

            linkedNodeList.AddFront(3);
            linkedNodeList.AddFront(2);
            linkedNodeList.AddBack(5);

            Console.WriteLine($"Size is : {linkedNodeList.Size()}");

            Console.WriteLine("LinkedListTask - End");
        }
    }
}
