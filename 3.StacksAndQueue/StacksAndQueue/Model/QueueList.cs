using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue.Model
{
    public class QueueList
    {
        private Node head;
        private Node tail;

        public bool IsEmpty() 
        {
            return this.head == null;
        }

        public void Add(int data) 
        {
            var newNode = new Node(data);
            if (this.tail != null) 
            {
                this.tail.Next = newNode;
            }

            this.tail = newNode;

            if (this.head == null) 
            {
                this.head = this.tail;
            }
        }

        public int Remove()
        {
            if (this.head == null)
                throw new NullReferenceException();

            var res = this.head.Data;

            this.head = this.head.Next;

            return res;
        }
    }
}
