using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DllImport(@"C:\Users\Ajay\Documents\Visual Studio 2017\Projects\CPPDLL\Debug\CPPDLL.dll", EntryPoint =
           "math_add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);
        [TestMethod]
        public void TestMethod1()
        {
         int result = Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
