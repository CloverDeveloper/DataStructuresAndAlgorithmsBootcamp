using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using BianryTree.Model;

namespace UnitTest
{
    [TestClass]
    public class Task_BianryTree
    {
        [TestMethod]
        public void Insert() 
        {
            var tree = new BinaryTree();

            tree.Insert(5, "a");
            tree.Insert(6, "b");
            tree.Insert(7, "c");
            tree.Insert(4, "f");

            var minNode = tree.Min();
            var maxNode = tree.Max();

            minNode.Should().NotBeNull();
            minNode.Key.Should().BeGreaterThanOrEqualTo(4);
            minNode.Value.Should().Be("f");

            maxNode.Should().NotBeNull();
            maxNode.Key.Should().BeGreaterThanOrEqualTo(7);
            maxNode.Value.Should().Be("c");
        }

        [TestMethod]
        public void Min() 
        {
            var tree = new BinaryTree();

            tree.Insert(5, "a");
            tree.Insert(6, "b");
            tree.Insert(7, "c");
            tree.Insert(4, "f");

            var minNode = tree.Min();

            minNode.Should().NotBeNull();
            minNode.Key.Should().BeGreaterThanOrEqualTo(4);
            minNode.Value.Should().Be("f");
        }

        [TestMethod]
        public void Max() 
        {
            var tree = new BinaryTree();

            tree.Insert(5, "a");
            tree.Insert(6, "b");
            tree.Insert(7, "c");
            tree.Insert(4, "f");

            var maxNode = tree.Max();

            maxNode.Should().NotBeNull();
            maxNode.Key.Should().BeGreaterThanOrEqualTo(7);
            maxNode.Value.Should().Be("c");
        }

        [TestMethod]
        public void Find()
        {
            var tree = new BinaryTree();

            tree.Insert(5, "a");
            tree.Insert(6, "b");
            tree.Insert(7, "c");
            tree.Insert(4, "f");

            var res = tree.Find(7);

            res.Key.Should().BeGreaterThanOrEqualTo(7);
            res.Value.Should().Be("c");
        }

        [TestMethod]
        public void Delete()
        {
            var tree = new BinaryTree();

            tree.Insert(5, "a");
            tree.Insert(10, "b");
            tree.Insert(9, "c");
            tree.Insert(4, "f");
            tree.Insert(12, "g");
            tree.Insert(11, "g");

            tree.Delete(12);

            var maxNode = tree.Max();
            maxNode.Should().NotBeNull();
            maxNode.Key.Should().Be(11);
            maxNode.Value.Should().Be("g");
        }
    }
}
