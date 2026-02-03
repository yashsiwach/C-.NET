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
}

public class Program
{
    public static int id=1;
    public static List<Book>data=new List<Book>();
}