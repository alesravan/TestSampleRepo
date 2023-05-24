using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Massivparallelism
{
    [TestClass]
    public class UnitTest3
    {
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
        [TestMethod]
        public void Test1()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test2()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test3()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test4()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test5()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test6()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test7()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test8()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test9()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test10()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test11()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test12()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test13()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test14()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test15()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test16()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test17()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test18()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test19()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test20()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test21()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test22()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test23()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test24()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test25()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test26()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test27()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test28()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test29()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test30()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test31()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test32()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test33()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test34()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test35()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test36()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test37()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test38()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test39()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test40()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test41()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test42()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test43()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test44()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test45()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test46()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test47()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test48()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test49()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test50()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test51()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test52()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test53()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test54()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test55()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test56()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test57()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test58()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test59()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test60()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test61()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test62()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test63()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test64()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test65()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test66()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test67()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test68()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test69()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Tes70()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test71()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test72()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test73()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test74()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test75()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test76()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test77()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test78()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test79()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test80()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test81()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test82()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test83()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test84()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test85()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test86()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test87()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test88()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test89()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test90()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test91()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test92()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test93()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test94()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test95()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test96()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test97()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test98()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test99()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }
        [TestMethod]
        public void Test100()
        {
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
            Thread.Sleep(60000);
        }

    }
}
