namespace LibarySystem
{
    namespace Items{
    public class Book : LibaryItem, INotifiable, IReseverable
    {
        public Book(string title, string author, int itemId)
        {
            this.title = title;
            this.author = author;
            this.itemId = itemId;
        }
        public override void Display()
        {
            System.Console.WriteLine("Title is:" + title);
            System.Console.WriteLine("Author is:" + author);
            System.Console.WriteLine("Id is :" + itemId);
        }
        public override void CalculateLateFee(int day)
        {
            // Book → 1 unit per day
            System.Console.WriteLine("Late charge for book is :" + day);

        }
        void INotifiable.Message(string msg)
        {
            System.Console.WriteLine("Notification message sent");
        }
        void IReseverable.Reserve()
        {
            System.Console.WriteLine("Reservation successfull");
        }


    }
    }
}