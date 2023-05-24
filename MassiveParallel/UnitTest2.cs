using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MassiveParallel
{
    [TestClass]
    public class UnitTest2
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
        //Check the first value we calculate
        public void BankTest()
        {
            Thread.Sleep(3000);
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreNotEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void BankTest1()
        {
            Thread.Sleep(3000);
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreNotEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void BankTest2()
        {
            Thread.Sleep(3000);
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreNotEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void BankTest3()
        {
            Thread.Sleep(3000);
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreNotEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
