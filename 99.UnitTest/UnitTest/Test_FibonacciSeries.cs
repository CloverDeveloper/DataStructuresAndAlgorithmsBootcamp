using FibonacciSeries.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class Test_FibonacciSeries
    {
        [TestMethod]
        public void NormalFib() 
        {
            var fibonacci = new Fibonacci();

            fibonacci.NormalFib(0).Should().Be(0);
            fibonacci.NormalFib(1).Should().Be(1);
            fibonacci.NormalFib(2).Should().Be(1);
            fibonacci.NormalFib(3).Should().Be(2);
            fibonacci.NormalFib(4).Should().Be(3);
            fibonacci.NormalFib(5).Should().Be(5);
            fibonacci.NormalFib(6).Should().Be(8);
            fibonacci.NormalFib(7).Should().Be(13);
            fibonacci.NormalFib(8).Should().Be(21);
        }

        [TestMethod]
        public void MemoFib()
        {
            var fibonacci = new Fibonacci();

            fibonacci.MemoFib(0).Should().Be(0);
            fibonacci.MemoFib(1).Should().Be(1);
            fibonacci.MemoFib(2).Should().Be(1);
            fibonacci.MemoFib(3).Should().Be(2);
            fibonacci.MemoFib(4).Should().Be(3);
            fibonacci.MemoFib(5).Should().Be(5);
            fibonacci.MemoFib(6).Should().Be(8);
            fibonacci.MemoFib(7).Should().Be(13);
            fibonacci.MemoFib(8).Should().Be(21);
        }

        [TestMethod]
        public void StripZeros()
        {
            var recursion = new Recursion();

            var res = recursion.StripZeros("00011");

            res.Should().Be("11");
        }
    }
}
