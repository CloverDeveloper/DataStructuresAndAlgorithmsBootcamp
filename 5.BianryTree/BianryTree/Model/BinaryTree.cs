using System;
using System.Collections.Generic;
using System.Text;

namespace BianryTree.Model
{
    public class BinaryTree
    {
        public BinaryTreeNode Data;

        public BinaryTreeNode Min() 
        {
            if (this.Data == null)
                return null;

            var currentNode = this.Data;
            while (currentNode.Left != null) 
            {
                currentNode = currentNode.Left;
            }

            return currentNode;
        }

        public BinaryTreeNode Max() 
        {
            if (this.Data == null) 
                return null;

            var currentNode = this.Data;
            while (currentNode.Right != null) 
            {
                currentNode = currentNode.Right;
            }

            return currentNode;
        }

        public void Insert(int key,string value) 
        {
            this.Data = this.InsertItem(this.Data, key, value);
        }

        private BinaryTreeNode InsertItem(BinaryTreeNode root, int key, string value) 
        {
            var newNode = new BinaryTreeNode(key, value);

            if (root == null) return newNode;

            if (root.Key < key) 
            {
                root.Right = this.InsertItem(root.Right, key, value);
            }

            if (root.Key > key) 
            {
                root.Left = this.InsertItem(root.Left, key, value);
            }

            return root;
        }

        public BinaryTreeNode Find(int key) 
        {
            return this.FineItem(this.Data, key);
        }

        private BinaryTreeNode FineItem(BinaryTreeNode root, int key) 
        {
            if (root == null)
                return null;

            if (root.Key == key) return root;

            if (root.Key < key)
            {
                return this.FineItem(root.Right, key);
            }

            if (root.Key > key)
            {
                return this.FineItem(root.Left,key);
            }

            return null;
        }

        public void Delete(int key) 
        {
            this.Data = this.DeleteItem(this.Data, key);
        }

        private BinaryTreeNode DeleteItem(BinaryTreeNode root, int key) 
        {
            if (root == null) return null;

            if (root.Key < key) 
            {
                root.Right = this.DeleteItem(root.Right, key);
            }

            if (root.Key > key) 
            {
                root.Left = this.DeleteItem(root.Left, key);
            }

            if (root.Left == null && root.Right == null) 
            {
                return null;
            }

            if (root.Left == null) 
            {
                return root.Right;
            }

            if (root.Right == null) 
            {
                return root.Left;
            }

            return root;
        }
    }
}
