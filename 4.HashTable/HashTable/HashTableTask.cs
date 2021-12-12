using Common.Interface;
using HashTable.Model;
using System;

namespace HashTable
{
    public class HashTableTask : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("HashTableTask - Start");

            var hashTableList = new HashTableList();

            Console.WriteLine("Pust - Key = T1-1,Value = XDD");

            hashTableList.Push("T1-1", "XDD");
            Console.WriteLine($"GetIndex = {hashTableList.GetIndex("T1-1")}");
            Console.WriteLine($"Value = {hashTableList.Get("T1-1")}");

            Console.WriteLine("HashTableTask - End");
        }
    }
}
