using Arrays.Model;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Test_Arrays
    {
        [TestMethod]
        public void GetByIndex()
        {
            var arrays = new DynamicArray<string>(2);

            var act = arrays.GetByIndex(0);

            act.Should().BeNull();
        }

        [TestMethod]
        public void SetByIndex()
        {
            var arrays = new DynamicArray<string>(2);

            var expect = arrays.SetByIndex(1, "Hello");

            var act = arrays.GetByIndex(1);

            act.Should().BeEquivalentTo(expect);
        }

        [TestMethod]
        public void InsertByIndex()
        {
            var arrays = new DynamicArray<string>(3);

            arrays.InsertByIndex(1, "Hello");
            arrays.InsertByIndex(1, "World");
            var expect = "World";

            var act = arrays.GetByIndex(1);

            act.Should().BeEquivalentTo(expect);
        }

        [TestMethod]
        public void DeleteByIndex()
        {
            var arrays = new DynamicArray<string>(3);

            arrays.SetByIndex(0, "Hello");
            arrays.SetByIndex(1, "World");
            arrays.SetByIndex(2, "End");

            var expectDeleteVal = "World";
            var deleteVal = arrays.DeleteByIndex(1);

            var expectCurrentVal = "End";
            var currentVal = arrays.GetByIndex(1);

            deleteVal.Should().BeEquivalentTo(expectDeleteVal);
            currentVal.Should().BeEquivalentTo(expectCurrentVal);
        }

        [TestMethod]
        public void IsEmpty()
        {
            var arrays = new DynamicArray<string>(3);

            arrays.IsEmpty().Should().BeTrue();
        }

        [TestMethod]
        public void Contains()
        {
            var arrays = new DynamicArray<string>(3);

            var expect = arrays.SetByIndex(0, "Hello");

            arrays.Contains(expect).Should().BeTrue();
        }

        [TestMethod]
        public void ReSize()
        {
            var initSize = 3;

            var arrays = new DynamicArray<string>(initSize);

            var expect = arrays.ReSize();

            expect.Should().Be(initSize *= 2);
        }

        [TestMethod]
        public void Print()
        {
            var initSize = 3;

            var arrays = new DynamicArray<string>(initSize);

            arrays.Print();
        }
    }
}
