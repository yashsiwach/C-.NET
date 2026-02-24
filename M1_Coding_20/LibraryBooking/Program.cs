public class Author
{
    public string? AuthorName{get;set;}
    public string? Country{get;set;}
}
public class Book
{
    public string? Title{get;set;}
    public double Price{get;set;}
    public Author? Owner{get;set;}
}
public class Program
{
    public static void Main(string[] args)
    {
        Book book1=new Book
        {
            Title="TestTitle1",
            Price=3435,
            Owner=new Author
            {
                AuthorName="author1",
                Country="india"
            }
        };
         Book book2=new Book
        {
            Title="TestTitle2",
            Price=3254,
            Owner=new Author
            {
                AuthorName="author2",
                Country="USA"
            }
        };
        System.Console.WriteLine(book1.Title+ " "+book1.Price+ " "+book1.Owner.AuthorName+ " "+book1.Owner.Country);
        System.Console.WriteLine(book2.Title+ " "+book2.Price+ " "+book2.Owner.AuthorName+ " "+book2.Owner.Country);

    }
}