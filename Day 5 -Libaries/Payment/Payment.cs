using System;
namespace Pay
{
   abstract class Payment
    {
        public int amount { get; }
        protected Payment(int amount)
        {
            this.amount = amount;
        }
        public void Show()
        {
            System.Console.WriteLine(" receipt " + amount);
        }
        public abstract void Pay();
    }
     class Upi : Payment
    {
        public string? upiId {get;}
        public Upi(int amount, string UpiId) : base(amount)
        {
            this.upiId = upiId;
        }
        public override void Pay()
        {
            System.Console.WriteLine(upiId + " " + amount);
        }
        
    }
}