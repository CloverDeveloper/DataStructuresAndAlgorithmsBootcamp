using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue.Model
{
    public class StackList
    {
        private Node head;

        public bool IsEmpty() 
        {
            return this.head == null;
        }

        public void Push(int data) 
        {
            var newNode = new Node(data);
            if (this.head == null) 
            {
                this.head = newNode;

                return;
            }

            newNode.Next = this.head;
            this.head = newNode;
        }

        public int Pop() 
        {
            if (this.head == null)
                throw new NullReferenceException();

            var res = this.head.Data;

            this.head = this.head.Next;

            return res;
        }
    }
}
