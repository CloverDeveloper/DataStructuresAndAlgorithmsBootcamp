using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    public class LinkedNodeList
    {
        private Node head;

        public void AddFront(int data) 
        {
            Node newNode = new Node(data);

            if(this.head == null) 
            {
                this.head = newNode;
                return;
            }

            newNode.Next = head;

            this.head = newNode;
        }

        public int GetFirst() 
        {
            if(this.head == null) 
            {
                throw new NullReferenceException();
            }

            return this.head.Data;
        }

        public int GetLast() 
        {
            if (this.head == null)
            {
                throw new NullReferenceException();
            }

            Node currentNode = this.head;

            while (currentNode.Next != null) 
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Data;
        }

        public void AddBack(int data)
        {
            Node newNode = new Node(data);

            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            Node currentNode = this.head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

        public int Size() 
        {
            int res = 0;

            Node currentNode = this.head;
            if (currentNode == null) return res;

            res += 1;
            while (currentNode.Next != null) 
            {
                currentNode = currentNode.Next;
                res += 1;
            }

            return res;
        }

        public void Clear()
        {
            this.head = null;
        }

        public void DeleteByValue(int data)
        {
            if (this.head == null) return;

            if(this.head.Data == data) 
            {
                this.head = this.head.Next;
                return;
            }

            Node currentNode = this.head;
            while (currentNode.Next != null) 
            {
                if (currentNode.Next.Data == data) 
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }

                currentNode = currentNode.Next;
            }
        }
    }
}
