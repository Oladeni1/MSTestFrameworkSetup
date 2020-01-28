using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestFramewoekSetup
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("This runs before Class");
        }
        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This runs after Class");
        }
        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This runs before Test");
        }
        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This runs after Test");
        }
        [TestMethod, TestCategory("Smoke Test")]
        public void TestMethod1()
        {
            Console.WriteLine("This runs the Test, Test category");
        }
    }
}
