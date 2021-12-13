using System;
using System.Collections.Generic;
using System.Text;

namespace BianryTree.Model
{
    public class BinaryTreeNode
    {
        public int Key;

        public string Value;

        public BinaryTreeNode Left;

        public BinaryTreeNode Right;

        public BinaryTreeNode(int key,string value) 
        {
            this.Value = value;
            this.Key = key;
        }
    }
}
