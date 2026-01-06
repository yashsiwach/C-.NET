using LibarySystem.Items;

namespace LibarySystem
{
    /// <summary>
    /// Static store class to maintain and display library items
    /// </summary>
    public static class Store
    {
        public static List<LibaryItem> Data = new List<LibaryItem>();

        /// <summary>
        /// Displays details of all items stored in the library
        /// Identifies item type and calls the respective Display method
        /// </summary>
        public static void DisplayItemDetails()
        {
            foreach (var item in Data)
            {
                if (item is Book)
                {
                    System.Console.WriteLine("Book");
                }
                else
                {
                    System.Console.WriteLine("Magazine");
                }

                item.Display();
            }
        }
    }
}
