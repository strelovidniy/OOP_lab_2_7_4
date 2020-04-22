using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, 9 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(9, result);
        }
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, 9 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(10, result);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(96, result);
        }
        public void TestMethod2()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(100, result);
        }
        public void TestMethod2()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 11, 21, 31, 41, 51, 61, 0, -71, 81, 90 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(90, result);
        }
        public void TestMethod2()
        {
            int[] a = { 11, 21, 31, 41, 51, 61, 0, -71, 81, 90 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(100, result);
        }
    }

    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 12, 22, 32, 42, 52, 62, 0, -72, 82, 90 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(90, result);
        }
        public void TestMethod2()
        {
            int[] a = { 12, 22, 32, 42, 52, 62, 0, -72, 82, 90 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(100, result);
        }
    }

    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 111, 222, 333, 444, 555, 666, 777, 888, 999, 0 };
            int result = OOP_lab_2_7_3.Program.maxAbs(a);
            Assert.AreEqual(999, result);
        }
        public void TestMethod2()
        {
            int[] a = { 111, 222, 333, 444, 555, 666, 777, 888, 999, 0 };
            int result = OOP_lab_2_7_3.Program.sumZero(a);
            Assert.AreEqual(0, result);
        }
    }

}
