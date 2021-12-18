using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using HashTable.Model;

namespace UnitTest
{
    [TestClass]
    public class Test_HashTable
    {
        [TestMethod]
        public void GetIndex() 
        {
            var hashTableList = new HashTableList();

            var res = hashTableList.GetIndex("Test");

            res.Should().BeGreaterThanOrEqualTo(0);
            res.Should().BeLessThanOrEqualTo(16);
        }

        [TestMethod]
        public void Push()
        {
            var hashTableList = new HashTableList();

            hashTableList.Push("T1-1", "XDD");
            hashTableList.Push("T1-2", "XD");
            hashTableList.Push("T2-1", "TTT");

            hashTableList.Should().NotBeNull();
        }

        [TestMethod]
        public void Get()
        {
            var hashTableList = new HashTableList();

            hashTableList.Push("T1-1", "XDD");
            hashTableList.Push("T1-2", "XD");
            hashTableList.Push("T2-1", "TTT");

            var res = hashTableList.Get("T1-1");
            var res2 = hashTableList.Get("T2-1");

            res.Should().Be("XDD");
            res2.Should().Be("TTT");
        }
    }
}
