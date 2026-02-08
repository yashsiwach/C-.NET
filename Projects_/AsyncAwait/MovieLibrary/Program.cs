public interface IFilm
{
    public string Title{get;set;}
}
public interface IFilmLibrary
{
    public void AddFilm(IFilm film);
    public void RemoveFilm(string title);
    public List<IFilm> GetFilms();
    public List<IFilm> SearchFilms(string query);
    public int GetTotalFilmCount();
}
public class Film:IFilm
{
    public string Title{get;set;}
    public string Director{get;set;}
    public int Year{get;set;}
}
public class FilmLibrary : IFilmLibrary
{
    private List<IFilm> _films=new List<IFilm>();
    public void AddFilm(IFilm film)
    {
        _films.Add(film);
    }
    public void RemoveFilm(string title)
    {
        var ele=_films.First(x=>x.Title==title);
        _films.Remove(ele);
    }
    public List<IFilm> GetFilms()
    {
        return _films;
    }
    public List<IFilm> SearchFilms(string query)
    {
        return _films.Where(x=>x.Title.Contains(query)||((Film)x).Director.Contains(query)).ToList();
    }
    public int GetTotalFilmCount()
    {
        return _films.Count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        FilmLibrary library=new FilmLibrary();
        library.AddFilm(new Film
        {
            Title="Inception",
            Director="Christopher Nolan",
            Year=2010
        });
         library.AddFilm(new Film
        {
            Title="intersteller",
            Director="Christopher Nolan",
            Year=2014
        });
         library.AddFilm(new Film
        {
            Title="Titanic",
            Director="James Cameron",
            Year=1997
        });
        library.SearchFilms("Nolan");
        
        Console.WriteLine("Films added successfully\n");

        // ---------------- TEST CASE 2: Display All Films ----------------
        Console.WriteLine("TEST CASE 2: Displaying all films");

        foreach (Film film in library.GetFilms())
        {
            Console.WriteLine($"{film.Title} | {film.Director} | {film.Year}");
        }
        Console.WriteLine();

        // ---------------- TEST CASE 3: Search by Director ----------------
        Console.WriteLine("TEST CASE 3: Search films by director 'Nolan'");

        List<IFilm> searchResult = library.SearchFilms("Nolan");
        foreach (Film film in searchResult)
        {
            Console.WriteLine($"{film.Title} | {film.Director}");
        }
        Console.WriteLine();

        // ---------------- TEST CASE 4: Remove a Film ----------------
        Console.WriteLine("TEST CASE 4: Removing film 'Titanic'");
        library.RemoveFilm("Titanic");

        Console.WriteLine("Remaining films:");
        foreach (Film film in library.GetFilms())
        {
            Console.WriteLine(film.Title);
        }
        Console.WriteLine();

        // ---------------- TEST CASE 5: Get Total Film Count ----------------
        Console.WriteLine("TEST CASE 5: Total film count");
        Console.WriteLine("Total Films: " + library.GetTotalFilmCount());
    }

    }
