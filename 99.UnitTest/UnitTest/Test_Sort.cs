using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Interface;
using Sort.Model;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class Test_Sort
    {
        [TestMethod]
        public void BubbleSort() 
        {
            int[] nums = new int[] { 8, 4, 7, 3, 6, 7, 8,9, 2, 1, 5 };

            ISort bubble = new BubbleSort();

            nums = bubble.Sort(nums);

            nums[0].Should().Be(1);
            nums[nums.Length - 1].Should().Be(9);
        }

        [TestMethod]
        public void MergeSort()
        {
            int[] nums = new int[] { 8, 4, 7, 3, 6, 7, 8, 9, 2, 1, 5 };

            ISort merge = new MergeSort();

            nums = merge.Sort(nums);

            nums[0].Should().Be(1);
            nums[nums.Length - 1].Should().Be(9);
        }
    }
}
