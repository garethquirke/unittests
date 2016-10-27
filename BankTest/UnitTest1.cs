using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double startBalance = 12;
            double debitAmount = 4;
            double expected = 16;

            BankAccount account = new BankAccount("Gareth Quirke", startBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual);
        }
    }
}
