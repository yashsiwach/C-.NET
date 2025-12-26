using System.Diagnostics;

namespace Project2
{
    /// <summary>
    /// Provides unit-test style validation methods for deposit and withdrawal operations
    /// using assertions and exception handling.
    /// </summary>
    public class UnitTest
    {
        /// <summary>
        /// Validates that the deposited amount correctly updates the account balance.
        /// </summary>
        public void Deposit_ValidAmount(double num, double Balance, double prevBalance)
        {
            Debug.Assert((num + prevBalance) == Balance, "Data Deposit Inconsistent");
            System.Console.WriteLine("Successful current Balance is: " + Balance);
        }

        /// <summary>
        /// Ensures that the deposit amount is positive and rejects negative values.
        /// </summary>
        public void Test_Deposit_NegativeAmount(double num)
        {
            Debug.Assert(num > 0, "Error negative value!");
            if (num < 0)
            {
                throw new ArgumentException("Negative value not allowed!!");
            }
        }

        /// <summary>
        /// Validates that the withdrawal correctly reduces the account balance.
        /// </summary>
        public void Test_Withdraw_ValidAmount(double num, double balance, double prevBalance)
        {
            Debug.Assert((prevBalance - num) == balance, "Data Withdrawal Inconsistent");
            System.Console.WriteLine("Successful current Balance is: " + balance);
        }

        /// <summary>
        /// Checks for sufficient funds before allowing a withdrawal.
        /// </summary>
        public void Test_Withdraw_InsufficientFunds(double num, double balance)
        {
            Debug.Assert(num < balance, "Error Amount is bigger than balance!");
            if (num > balance)
            {
                throw new ArgumentException("Insufficient Amount in Account!!");
            }
        }
    }
}
