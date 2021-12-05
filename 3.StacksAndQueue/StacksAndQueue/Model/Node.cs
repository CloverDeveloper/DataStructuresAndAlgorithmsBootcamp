using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue.Model
{
    public class Node
    {
        public Node Next;

        public int Data;

        public Node(int data) 
        {
            this.Data = data;
        }
    }
}
