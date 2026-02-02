using NUnit.Framework;
using System;

// Marks this class as a test class for NUnit
[TestFixture]
public class UnitTest
{
    // Test to verify deposit with a valid amount increases the balance
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        // Arrange: create account with initial balance
        Program acc = new Program(100m);

        // Act: deposit valid amount
        acc.Deposit(50m);

        // Assert: check updated balance
        Assert.AreEqual(150m, acc.Balance);
    }

    // Test to verify deposit with a negative amount throws exception
    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        // Arrange: create account with initial balance
        Program acc = new Program(100m);

        // Act & Assert: exception should be thrown with correct message
        var ex = Assert.Throws<Exception>(() => acc.Deposit(-20m));
        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    // Test to verify withdrawal with valid amount decreases balance
    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        // Arrange: create account with initial balance
        Program acc = new Program(200m);

        // Act: withdraw valid amount
        acc.Withdraw(80m);

        // Assert: check updated balance
        Assert.AreEqual(120m, acc.Balance);
    }

    // Test to verify withdrawal exceeding balance throws exception
    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        // Arrange: create account with initial balance
        Program acc = new Program(100m);

        // Act & Assert: exception should be thrown with correct message
        var ex = Assert.Throws<Exception>(() => acc.Withdraw(150m));
        Assert.AreEqual("Insufficient funds.", ex.Message);
    }
}

