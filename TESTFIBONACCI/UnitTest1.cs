using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TESTFIBONACCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Fibonacci_Ejercicio2.Program.fibonacci(10);
            Assert.AreEqual(55, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Fibonacci_Ejercicio2.Program.fibonacci(10);
            Assert.AreEqual(89, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Fibonacci_Ejercicio2.Program.fibonacci(3);
            Assert.AreEqual(3, result);
        }
    }
}
