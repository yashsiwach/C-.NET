using NUnit.Framework;
using System;
using Project2;

namespace Project2.Tests
{
    /// <summary>
    /// NUnit test fixture for the Account class.
    /// </summary>
    [TestFixture]
    public class AccountTests
    {
        /// <summary>
        /// Tests that depositing a valid amount increases the balance correctly.
        /// </summary>
        [Test]
        public void Test_Deposit_ValidAmount()
        {
            // Arrange: create account with initial balance
            Account acc = new Account(100m);

            // Act: deposit valid amount
            acc.Deposit(50m);

            // Assert: check updated balance
            Assert.AreEqual(150m, acc.Balance);
        }

        /// <summary>
        /// Tests that depositing a negative amount throws an exception.
        /// </summary>
        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            // Arrange: create account with initial balance
            Account acc = new Account(100m);

            // Act & Assert: exception should be thrown with correct message
            var ex = Assert.Throws<Exception>(() => acc.Deposit(-20m));
            Assert.AreEqual("Deposit amount cannot be negative", ex!.Message);
        }

        /// <summary>
        /// Tests that withdrawing a valid amount decreases the balance correctly.
        /// </summary>
        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            // Arrange: create account with initial balance
            Account acc = new Account(200m);

            // Act: withdraw valid amount
            acc.Withdraw(80m);

            // Assert: check updated balance
            Assert.AreEqual(120m, acc.Balance);
        }

        /// <summary>
        /// Tests that withdrawing more than the balance throws an exception.
        /// </summary>
        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            // Arrange: create account with initial balance
            Account acc = new Account(100m);

            // Act & Assert: exception should be thrown with correct message
            var ex = Assert.Throws<Exception>(() => acc.Withdraw(150m));
            Assert.AreEqual("Insufficient funds.", ex!.Message);
        }
    }
}
