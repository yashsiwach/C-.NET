using System;

namespace Project2
{
    /// <summary>
    /// Represents a bank account with deposit and withdrawal operations.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// Initializes a new account with the specified balance.
        /// </summary>
        /// <param name="initialBalance">The initial balance.</param>
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        /// <summary>
        /// Deposits the specified amount into the account.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <exception cref="Exception">Thrown when amount is negative.</exception>
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Deposit amount cannot be negative");
            }
            Balance += amount;
        }

        /// <summary>
        /// Withdraws the specified amount from the account.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <exception cref="Exception">Thrown when funds are insufficient.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds.");
            }
            Balance -= amount;
        }
    }
}
