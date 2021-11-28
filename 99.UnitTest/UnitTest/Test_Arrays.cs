using Arrays.Model;
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

            Assert.IsNull(act);
        }

        [TestMethod]
        public void SetByIndex()
        {
            var arrays = new DynamicArray<string>(2);

            var expect = arrays.SetByIndex(1, "Hello");

            var act = arrays.GetByIndex(1);

            Assert.AreEqual(expect, act);
        }

        [TestMethod]
        public void InsertByIndex()
        {
            var arrays = new DynamicArray<string>(3);

            arrays.InsertByIndex(1, "Hello");
            arrays.InsertByIndex(1, "World");
            var expect = "World";

            var act = arrays.GetByIndex(1);

            Assert.AreEqual(expect, act);
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

            Assert.AreEqual(expectDeleteVal, deleteVal);
            Assert.AreEqual(expectCurrentVal, currentVal);
        }

        [TestMethod]
        public void IsEmpty()
        {
            var arrays = new DynamicArray<string>(3);

            Assert.IsTrue(arrays.IsEmpty());
        }

        [TestMethod]
        public void Contains()
        {
            var arrays = new DynamicArray<string>(3);

            var expect = arrays.SetByIndex(0, "Hello");

            Assert.IsTrue(arrays.Contains(expect));
        }

        [TestMethod]
        public void ReSize()
        {
            var initSize = 3;

            var arrays = new DynamicArray<string>(initSize);

            var expect = arrays.ReSize();

            Assert.AreEqual(expect,initSize *= 2);
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
