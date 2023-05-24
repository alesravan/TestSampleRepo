using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

[assembly: Parallelize(Workers = 100, Scope = ExecutionScope.MethodLevel)]
namespace MassiveParallel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine("AssemblyInit " + context.TestName);
        }
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine("ClassInit " + context.TestName);
        }

        [TestInitialize]
        public void Initialize()
        {
            Console.WriteLine("TestMethodInit");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("TestMethodCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("AssemblyCleanup");
        }
        [TestMethod]
        public void X()
        {
           
            Caluclator obj = new Caluclator();
            Assert.AreEqual(300, obj.Covered(10, 10));
            // Assert.AreEqual(10, obj.Sub(20, 10));
            //Assert.AreEqual(100, obj.Mul(10, 10));
            //Assert.AreEqual(10, obj.Div(100, 10));
        }
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(3000);
            Caluclator obj = new Caluclator();
            Assert.AreEqual(20, obj.Add(10, 10));
            // Assert.AreEqual(10, obj.Sub(20, 10));
            Assert.AreEqual(100, obj.Mul(10, 10));
            Assert.AreEqual(10, obj.Div(100, 10));
        }
        [TestMethod]
        public void Verifyoddeven()
        {
            Thread.Sleep(3000);
            Caluclator obj = new Caluclator();
            Assert.AreEqual(20, obj.Add(10, 10));
            // Assert.AreEqual(10, obj.Sub(20, 10));
            Assert.AreEqual(100, obj.Mul(10, 10));
            Assert.AreEqual(10, obj.Div(100, 10));
        }
        [TestMethod]
        public void Verifybiggernumber()
        {
            Thread.Sleep(3000);
            Caluclator obj = new Caluclator();
            Assert.AreEqual(20, obj.Add(10, 10));
            // Assert.AreEqual(10, obj.Sub(20, 10));
            Assert.AreEqual(100, obj.Mul(10, 10));
            Assert.AreEqual(10, obj.Div(100, 10));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(3000);
            Caluclator obj = new Caluclator();
            Assert.AreEqual(20, obj.Add(10, 10));
        }
    }
}
