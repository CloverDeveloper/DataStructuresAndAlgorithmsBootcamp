using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Model;

namespace UnitTest
{
    [TestClass]
    public class Test_StacksAndQueue
    {
        [TestMethod]
        public void StacksPush() 
        {
            var stackList = new StackList();

            stackList.Push(1);
            stackList.Push(2);

            stackList.IsEmpty().Should().NotBe(true);
        }

        [TestMethod]
        public void StacksPop()
        {
            var stackList = new StackList();

            stackList.Push(1);
            var res = stackList.Pop();

            stackList.IsEmpty().Should().Be(true);
            res.Should().BeGreaterThanOrEqualTo(1);
        }

        [TestMethod]
        public void QueueAdd()
        {
            var queueList = new QueueList();

            queueList.Add(1);
            queueList.Add(2);

            queueList.IsEmpty().Should().NotBe(true);
        }

        [TestMethod]
        public void QueueRemove()
        {
            var queueList = new QueueList();

            queueList.Add(1);
            var res = queueList.Remove();

            queueList.IsEmpty().Should().Be(true);
            res.Should().BeGreaterThanOrEqualTo(1);
        }
    }
}
