using Common.Interface;
using StacksAndQueue.Model;
using System;

namespace StacksAndQueue
{
    public class StacksAndQueueTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("StacksAndQueueTask - Start");
            Console.WriteLine("Stacks - Start");

            var stackList = new StackList();
            Console.WriteLine($"StackList Is Empty:{stackList.IsEmpty()}");

            stackList.Push(1);
            Console.WriteLine($"StackList Push 1 Is Empty:{stackList.IsEmpty()}");

            var stackListPopRes = stackList.Pop();
            Console.WriteLine($"StackList Pop Res : {stackListPopRes} Is Empty:{stackList.IsEmpty()}");

            Console.WriteLine("Stacks - End");
            Console.WriteLine("Queue - Start");

            var queueList = new QueueList();
            Console.WriteLine($"QueueList Is Empty:{queueList.IsEmpty()}");

            queueList.Add(3);
            Console.WriteLine($"QueueList Add 3 Is Empty:{queueList.IsEmpty()}");

            var queueListRemoveRes = queueList.Remove();
            Console.WriteLine($"QueueList Remove Res : {queueListRemoveRes} Is Empty:{queueList.IsEmpty()}");

            Console.WriteLine("Queue - End");
            Console.WriteLine("StacksAndQueueTask - End");
        }
    }
}
