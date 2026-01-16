// Interface representing a book entity
public interface IBook
{
    // Unique identifier of the book
    int Id { get; set; }

    // Title of the book
    string? Title { get; set; }

    // Author name of the book
    string? Author { get; set; }

    // Category to which the book belongs
    string? Catagory { get; set; }

    // Price of a single book
    int Price { get; set; }
}

// Concrete implementation of IBook
public class Book : IBook
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Catagory { get; set; }
    public int Price { get; set; }
}

// Interface defining library operations
public interface ILibrarySystem
{
    // Adds a book with given quantity
    void AddBook(IBook book, int quantity);

    // Removes a quantity of a book
    void RemoveBook(IBook book, int quantity);

    // Returns total price grouped by category
    List<Tuple<string, int>> CatagoryTotalPrice();

    // Returns total price of all books
    int CalculateTotal();

    // Returns book title, quantity, and price
    List<Tuple<string, int, int>> BooksInfo();

    // Returns category, author, and total count of books
    List<Tuple<string, string, int>> CategoryAndAuthorWithCount();
}

// Implementation of the library system
public class LibrarySystem : ILibrarySystem
{
    // Stores books as key and quantity as value
    private Dictionary<IBook, int> _books = new Dictionary<IBook, int>();

    // Adds or updates a book quantity
    public void AddBook(IBook book, int quantity)
    {
        _books[book] = quantity;
    }

    // Decreases quantity of a book
    public void RemoveBook(IBook book, int quantity)
    {
        _books[book] -= quantity;
    }

    // Calculates total price per category
    public List<Tuple<string, int>> CatagoryTotalPrice()
    {
        List<Tuple<string, int>> ordered = new List<Tuple<string, int>>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // Aggregate price category-wise
        foreach (var i in _books)
        {
            if (dict.ContainsKey(i.Key.Catagory))
            {
                dict[i.Key.Catagory] += (i.Key.Price * i.Value);
            }
            else
            {
                dict[i.Key.Catagory] = (i.Key.Price * i.Value);
            }
        }

        // Convert dictionary to list of tuples
        foreach (var i in dict)
        {
            ordered.Add(new Tuple<string, int>(i.Key, i.Value));
        }

        return ordered;
    }

    // Calculates total price of all books
    public int CalculateTotal()
    {
        return _books.Sum(x => x.Key.Price * x.Value);

    }

    // Returns book title, quantity, and price
    public List<Tuple<string, int, int>> BooksInfo()
    {
        List<Tuple<string, int, int>> ordered = new List<Tuple<string, int, int>>();

        foreach (var i in _books)
        {
            ordered.Add(new Tuple<string, int, int>(i.Key.Title, i.Value, i.Key.Price));
        }

        return ordered;
    }

    // Groups books by category and then by author with count
    public List<Tuple<string, string, int>> CategoryAndAuthorWithCount()
    {
        List<Tuple<string, string, int>> ordered = new List<Tuple<string, string, int>>();
        Dictionary<string, List<IBook>> catagoryWise = new Dictionary<string, List<IBook>>();

        // Group books category-wise
        foreach (var i in _books)
        {
            if (!catagoryWise.ContainsKey(i.Key.Catagory))
                catagoryWise[i.Key.Catagory] = new List<IBook>();

            catagoryWise[i.Key.Catagory].Add(i.Key);
        }

        // For each category, count books author-wise
        foreach (var i in catagoryWise)
        {
            string cata = i.Key;
            Dictionary<string, int> authorWise = new Dictionary<string, int>();

            foreach (var j in i.Value)
            {
                if (!authorWise.ContainsKey(j.Author))
                    authorWise[j.Author] = 0;

                authorWise[j.Author] += _books[j];
            }

            // Store results in tuple list
            foreach (var j in authorWise)
            {
                ordered.Add(new Tuple<string, string, int>(cata, j.Key, j.Value));
            }
        }

        return ordered;
    }
}

// Entry point of the program
public class Program
{
    public static void Main(string[] args)
    {
        // Create library system instance
        LibrarySystem librarySystem = new LibrarySystem();

        // Add books to library
        librarySystem.AddBook(new Book
        {
            Id = 1,
            Title = "PeterPan",
            Author = "JamesMatheewBarrie",
            Catagory = "KidsClassics",
            Price = 193,
        }, 11);

        librarySystem.AddBook(new Book
        {
            Id = 2,
            Title = "tu meri m tera",
            Author = "FrankBaum",
            Catagory = "Man",
            Price = 394,
        }, 3);

        librarySystem.AddBook(new Book
        {
            Id = 1,
            Title = "Jai shree ram",
            Author = "JamesMatheewBarrie",
            Catagory = "KidsClassics",
            Price = 193,
        }, 11);

        librarySystem.AddBook(new Book
        {
            Id = 2,
            Title = "Pappu pass",
            Author = "FrankBaum",
            Catagory = "Man",
            Price = 394,
        }, 3);

        // Fetch different reports
        var bookInfo = librarySystem.BooksInfo();
        var authorWise = librarySystem.CategoryAndAuthorWithCount();
        int total = librarySystem.CalculateTotal();
        var catagoryWise = librarySystem.CatagoryTotalPrice();

        // Display book information
        System.Console.WriteLine("Boooks:");
        bookInfo.ForEach(x => System.Console.WriteLine($" {x.Item1} - {x.Item2} - {x.Item3}"));

        System.Console.WriteLine();
        System.Console.WriteLine("Catagory -> AuthWise: ");
        authorWise.ForEach(x => System.Console.WriteLine($" {x.Item1} - {x.Item2} - {x.Item3}"));

        System.Console.WriteLine();
        System.Console.WriteLine("Total:-" + total);

        System.Console.WriteLine("Catagory Wise:");
        catagoryWise.ForEach(x => System.Console.WriteLine($" {x.Item1} - {x.Item2}  "));
    }
}
