using System;

namespace Pay
{
    #region Payment Abstraction

    /// <summary>
    /// Abstract base class that defines
    /// common payment behavior.
    /// </summary>
    abstract class Payment
    {
        #region Constructors

        protected Payment(int amount)
        {
            this.amount = amount;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displays the payment receipt.
        /// </summary>
        public void Show()
        {
            System.Console.WriteLine(" receipt " + amount);
        }

        /// <summary>
        /// Performs the payment operation.
        /// Must be implemented by derived classes.
        /// </summary>
        public abstract void Pay();

        #endregion

        #region Data Members

        public int amount { get; }

        #endregion
    }

    #endregion

    #region UPI Payment Class

    /// <summary>
    /// Upi class implements the Payment abstraction
    /// and provides UPI-based payment logic.
    /// </summary>
    class Upi : Payment
    {
        #region Constructors

        public Upi(int amount, string UpiId) : base(amount)
        {
            this.upiId = upiId;
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Executes the UPI payment.
        /// </summary>
        public override void Pay()
        {
            System.Console.WriteLine(upiId + " " + amount);
        }

        #endregion

        #region Data Members

        public string? upiId { get; }

        #endregion
    }

    #endregion
}
