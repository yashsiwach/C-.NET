using LibarySystem.Items;
namespace LibarySystem
{
    public static class Store
    {
        public static List<LibaryItem> Data=new List<LibaryItem>();
        public static void DisplayItemDetails()
        {
            foreach(var item in Data)
            {
                if(item is Book)
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