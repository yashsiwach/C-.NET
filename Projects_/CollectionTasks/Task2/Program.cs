// Movie class represents a single movie entity
public class Movie
{
    // Movie title
    public string? Title { get; set; }

    // Movie artist / director / actor
    public string? Artist { get; set; }

    // Movie genre (Action, Drama, etc.)
    public string? Genre { get; set; }

    // Movie rating (integer value)
    public int Ratings { get; set; }
}

public class Program
{
    // Static list to store all movies
    public static List<Movie> MovieList = new List<Movie>();

    public static void Main(String[] args)
    {
        // Creating Program object to call non-static methods
        Program obj = new Program();

        // Number of movies to add
        int num = 2;

        // Loop to take movie input
        while (num > 0)
        {
            num = num - 1;

            // Ask user to enter movie details
            System.Console.WriteLine("Enter Movie details , seprated");

            // Read movie details from console
            string? movie = Console.ReadLine();

            // Add movie to list
            obj.AddMovie(movie);
        }

        // Ask user for genre to filter movies
        System.Console.WriteLine("Enter Genre");
        string? genre = Console.ReadLine();

        // Get movies filtered by genre
        var genreFilter = obj.ViewMoviesByGenre(genre);

        // Print movies filtered by genre
        genreFilter.ForEach(x =>
            System.Console.Write($"Title: {x.Title} Artist: {x.Artist} Genre: {x.Genre} Rating: {x.Ratings}  ")
        );

        System.Console.WriteLine();

        // Get movies sorted by ratings
        var ratingWise = obj.ViewMoviesByRatings();

        // Print movies sorted by ratings
        ratingWise.ForEach(x =>
            System.Console.Write($"Title: {x.Title} Artist: {x.Artist} Genre: {x.Genre} Rating: {x.Ratings} ")
        );

        System.Console.WriteLine();
    }

    // Method to add a movie to MovieList
    public void AddMovie(string MovieDetails)
    {
        // Split input string by comma
        var data = MovieDetails.Split(',').ToList();

        // Create Movie object using split data
        Movie obj = new Movie
        {
            Title = data[0],
            Artist = data[1],
            Genre = data[2],
            Ratings = int.Parse(data[3])
        };

        // Add movie to list
        MovieList.Add(obj);
    }

    // Returns movies matching the given genre
    public List<Movie> ViewMoviesByGenre(string genre)
    {
        // Filter movies by genre
        var movie = MovieList.Where(x => x.Genre == genre).ToList();
        return movie;
    }

    // Returns movies sorted by ratings (ascending)
    public List<Movie> ViewMoviesByRatings()
    {
        // Sort movies based on ratings
        var sorted = MovieList.OrderBy(x => x.Ratings).ToList();
        return sorted;
    }
}
