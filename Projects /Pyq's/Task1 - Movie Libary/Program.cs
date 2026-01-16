public interface IFilm
{
    string? Title { get; set; }
    string? Director { get; set; }
    int Year { get; set; }
}
public interface IFilmLibary
{
    void AddFilm(IFilm film);
    public void RemoveFilm(string title);
    public List<IFilm> GetFilms();
    public List<IFilm> SearchFilms(string query);
    public int GetTotalFilms();
}
public class Film : IFilm
{
    public string? Title { get; set; }
    public string? Director { get; set; }
    public int Year { get; set; }

}
public class FilmLibrary : IFilmLibary
{
    private List<IFilm> _films = new List<IFilm>();
    public void AddFilm(IFilm film)
    {
        _films.Add(film);
    }
    public void RemoveFilm(string title)
    {
        foreach (Film i in _films)
        {
            if (i.Title == title)
            {
                _films.Remove(i);
                break;
            }
        }
        System.Console.WriteLine("Deleted !");
    }
    public List<IFilm> GetFilms()
    {
        return _films;
    }
    //might be erro rin the for loop explicit 
    public List<IFilm> SearchFilms(string query)
    {
        List<IFilm> result = new List<IFilm>();
        foreach (IFilm i in _films)
        {
            if (i.Title.Contains(query) || i.Director.Contains(query))
            {
                result.Add(i);
            }
        }
        return result;
    }
    public int GetTotalFilms()
    {
        return _films.Count;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        IFilm film1 = new Film { Title = "test1", Director="d1",Year= 2003 };
        IFilm film2 = new Film { Title = "test2", Director="d2", Year=2033 };
        IFilm film3 = new Film { Title = "test3", Director="d3", Year=2023 };

        FilmLibrary filmLibrary = new FilmLibrary();
        filmLibrary.AddFilm(film1);
        filmLibrary.AddFilm(film2);
        filmLibrary.AddFilm(film3);

        var films = filmLibrary.GetFilms();
        films.ForEach(x => System.Console.WriteLine(x.Title + " " + x.Director + " " + x.Year));

        filmLibrary.RemoveFilm("test2");

        var films2 = filmLibrary.GetFilms();
        films2.ForEach(x => System.Console.WriteLine(x.Title + " " + x.Director + " " + x.Year));
        System.Console.WriteLine();

        var filtered = filmLibrary.SearchFilms("est3");
        var filtered1 = filmLibrary.SearchFilms("d");
        filtered.ForEach(x => System.Console.WriteLine(x.Title + " " + x.Director + " " + x.Year));
        filtered1.ForEach(x => System.Console.WriteLine(x.Title + " " + x.Director + " " + x.Year));
        System.Console.WriteLine();

        System.Console.WriteLine(filmLibrary.GetTotalFilms());


    }
}
