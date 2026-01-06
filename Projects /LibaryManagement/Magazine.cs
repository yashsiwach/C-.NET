namespace LibarySystem
{
    namespace Items
    {
        /// <summary>
        /// Magazine class represents a magazine item in the library
        /// Inherits from LibaryItem
        /// </summary>
        public class Magazine : LibaryItem
        {
            /// <summary>
            /// Constructor to initialize magazine details
            /// </summary>
            /// <param name="title">Title of the magazine</param>
            /// <param name="author">Author or publisher</param>
            /// <param name="itemId">Unique item identifier</param>
            public Magazine(string title, string author, int itemId)
            {
                this.title = title;
                this.author = author;
                this.itemId = itemId;
            }

            /// <summary>
            /// Displays magazine details
            /// </summary>
            public override void Display()
            {
                System.Console.WriteLine("Title is:" + title);
                System.Console.WriteLine("Author is:" + author);
                System.Console.WriteLine("Id is :" + itemId);
            }

            /// <summary>
            /// Calculates late fee for magazine
            /// Magazine has a charge of 0.5 unit per day
            /// </summary>
            /// <param name="day">Number of late days</param>
            public override void CalculateLateFee(int day)
            {
                System.Console.WriteLine("Late charge for magazine is :" + (day * 0.5));
            }
        }
    }
}
