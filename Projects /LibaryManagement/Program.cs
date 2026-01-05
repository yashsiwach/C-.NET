using LibarySystem;
using LibarySystem.Items;

public class Program
{
    public static void Main()
    {
        // Task 1

        Book book1=new Book("Book1","bookauthor1",1);
        Magazine magazine1=new Magazine("magazine1","magazineauthor1",2);
        System.Console.WriteLine("Book Details:");
        book1.Display();
        System.Console.WriteLine("Magazine Details:");
        magazine1.Display();

        // Task 2 & 4
        
        INotifiable notification=new Book("Book3","bookauthor3",3);
        IReseverable reserve=new Book("Book4","bookauthor4",4);
        notification.Message("test");
        reserve.Reserve();

        // Task 3

        Store.Data.Add(book1);
        Store.Data.Add(magazine1);
        Store.DisplayItemDetails();

        // Task 5
        LibarySystem.Items.Book obj=new LibarySystem.Items.Book("Book5","bookauthor5",5);
        obj.Display();

        // Task 6
        LibraryAnalytics.Total++;
        LibraryAnalytics.Display();

    }
}