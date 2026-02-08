public class Book
{
    public int Id{get;set;}
    public string? Title{get;set;}
    public string? Author{get;set;}
    public string? Genre{get;set;}
    public int PublicationYear{get;set;}
}
public class LibraryUtility
{
    public void AddBook(string title,string author,string genre,int year)
    {
        Program.data.Add(new Book{Id=Program.id++,Title=title,Author=author,Genre=genre,PublicationYear=year});
    }
    public SortedDictionary<string, List<Book>> GroupBooksByGenre()
    {
        SortedDictionary<string,List<Book>> res=new SortedDictionary<string, List<Book>>();
        var temp=Program.data.GroupBy(x=>x.Genre);
        foreach(var i in temp)
        {
            res[i.Key]=i.ToList();
        }
        return res;
    }
    public List<Book> GetBooksByAuthor(string author)
    {
        return Program.data.Where(x=>x.Author==author).ToList();
    }
    
    public int GetTotalBooksCount()
    {
        return Program.data.Count;
    }
}


public class Program
{
    public static int id=1;
    public static List<Book>data=new List<Book>();
    public static void Main(string[] args)
{
    LibraryUtility lib = new LibraryUtility();

    lib.AddBook("Clean Code", "Robert Martin", "Programming", 2008);
    lib.AddBook("The Pragmatic Programmer", "Andrew Hunt", "Programming", 1999);
    lib.AddBook("Harry Potter", "J.K. Rowling", "Fantasy", 1997);
    lib.AddBook("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937);
    lib.AddBook("Effective Java", "Joshua Bloch", "Programming", 2001);

    Console.WriteLine("Total Books: " + lib.GetTotalBooksCount());

    Console.WriteLine("\nBooks by Author: Robert Martin");
    var authorBooks = lib.GetBooksByAuthor("Robert Martin");
    foreach (var b in authorBooks)
    {
        Console.WriteLine($"{b.Title} ({b.PublicationYear})");
    }

    Console.WriteLine("\nBooks Grouped By Genre:");
    var grouped = lib.GroupBooksByGenre();
    foreach (var genre in grouped)
    {
        Console.WriteLine($"Genre: {genre.Key}");
        foreach (var book in genre.Value)
        {
            Console.WriteLine($"  {book.Title} - {book.Author}");
        }
    }
}
}