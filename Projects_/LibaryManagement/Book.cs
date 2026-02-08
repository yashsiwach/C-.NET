namespace LibarySystem
{
    // Sub-namespace to group all library items
    namespace Items
    {
        /// <summary>
        /// Book class represents a book item in the library.
        /// It inherits LibaryItem and implements INotifiable and IReseverable interfaces.
        /// </summary>
        public class Book : LibaryItem, INotifiable, IReseverable
        {
            /// <summary>
            /// Constructor to initialize book details
            /// </summary>
            /// <param name="title">Title of the book</param>
            /// <param name="author">Author of the book</param>
            /// <param name="itemId">Unique item identifier</param>
            public Book(string title, string author, int itemId)
            {
                this.title = title;
                this.author = author;
                this.itemId = itemId;
                this.type = ItemStatus.Available;
            }

            /// <summary>
            /// Displays book details like title, author, and item id
            /// </summary>
            public override void Display()
            {
                System.Console.WriteLine("Title is:" + title);
                System.Console.WriteLine("Author is:" + author);
                System.Console.WriteLine("Id is :" + itemId);
            }

            /// <summary>
            /// Calculates late fee for book based on number of days
            /// Book has a charge of 1 unit per day
            /// </summary>
            /// <param name="day">Number of late days</param>
            public override void CalculateLateFee(int day)
            {
                System.Console.WriteLine("Late charge for book is :" + day);
            }

            /// <summary>
            /// Explicit interface implementation for notification message
            /// </summary>
            /// <param name="msg">Notification message</param>
            void INotifiable.Message(string msg)
            {
                System.Console.WriteLine("Notification message sent");
            }

            /// <summary>
            /// Explicit interface implementation to reserve the book
            /// </summary>
            void IReseverable.Reserve()
            {
                System.Console.WriteLine("Reservation successfull");
            }
        }
    }
}
