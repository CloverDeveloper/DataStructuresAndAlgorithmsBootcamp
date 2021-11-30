using LinkedList.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class Test_LinkedList
    {
        private LinkedNodeList linkedNodeList;

        [TestMethod]
        public void AddFront()
        {
            this.linkedNodeList = new LinkedNodeList();
            this.linkedNodeList.AddFront(1);
            this.linkedNodeList.AddFront(2);
            this.linkedNodeList.AddFront(3);

            var expectFront = 3;
            var expectLast = 1;

            this.linkedNodeList.GetFirst().Should().Be(expectFront);
            this.linkedNodeList.GetLast().Should().Be(expectLast);
        }

        [TestMethod]
        public void GetFirst() 
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);

            var expect = 3;

            this.linkedNodeList.GetFirst().Should().Be(expect);
        }

        [TestMethod]
        public void GetLast()
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);
            this.linkedNodeList.AddFront(2);

            var expect = 3;

            this.linkedNodeList.GetLast().Should().Be(expect);
        }

        [TestMethod]
        public void AddBack()
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);
            this.linkedNodeList.AddFront(2);
            this.linkedNodeList.AddBack(5);

            var expect = 5;

            this.linkedNodeList.GetLast().Should().Be(expect);
        }

        [TestMethod]
        public void GetSize()
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);
            this.linkedNodeList.AddFront(2);
            this.linkedNodeList.AddBack(5);

            var expect = 3;

            this.linkedNodeList.Size().Should().Be(expect);
        }

        [TestMethod]
        public void Clear()
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);
            this.linkedNodeList.AddFront(2);
            this.linkedNodeList.AddBack(5);

            this.linkedNodeList.Clear();

            var expect = 0;

            this.linkedNodeList.Size().Should().Be(expect);
        }

        [TestMethod]
        public void DeleteByValue()
        {
            this.linkedNodeList = new LinkedNodeList();

            this.linkedNodeList.AddFront(3);
            this.linkedNodeList.AddFront(2);
            this.linkedNodeList.AddBack(5);

            this.linkedNodeList.DeleteByValue(2);

            var expect = 3;

            this.linkedNodeList.GetFirst().Should().Be(expect);
        }
    }
}
