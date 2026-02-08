public class MovieScreening
{
    public string MovieTitle { get; set; }
    public DateTime ShowTime { get; set; }
    public string ScreenNumber { get; set; }
    public int TotalSeats { get; set; }
    public int BookedSeats { get; set; }
    public double TicketPrice { get; set; }

}
public class Theater
{
    public void AddScreening(string title, DateTime time, string screen, int seats, double price)
    {
        Program.data.Add(new MovieScreening { MovieTitle = title, ShowTime = time, TotalSeats = seats, TicketPrice = price });
    }

    public bool BookTickets(string movieTitle, DateTime showTime, int tickets)
    {
        var screening = Program.data.FirstOrDefault(x =>
            x.MovieTitle == movieTitle &&
            x.ShowTime == showTime &&
            x.TotalSeats - x.BookedSeats >= tickets);

        if (screening == null)
            return false;

        screening.BookedSeats += tickets;
        return true;
    }


    public Dictionary<string, List<MovieScreening>> GroupScreeningsByMovie()
    {
        return Program.data
            .GroupBy(x => x.MovieTitle)
            .ToDictionary(g => g.Key, g => g.ToList());
    }

    public double CalculateTotalRevenue()
    {
        return Program.data.Select(x => x.TicketPrice * x.BookedSeats).ToList().Sum();
    }

    public List<MovieScreening> GetAvailableScreenings(int minSeats)
    {
        return Program.data.Where(x => x.TotalSeats - x.BookedSeats >= minSeats).ToList();
    }
}
public class Program
{
    public static List<MovieScreening> data = new List<MovieScreening>();
    public static void Main()
    {
        Theater theater = new Theater();

        theater.AddScreening(
            "Inception",
            new DateTime(2026, 2, 2, 18, 30, 0),
            "Screen 1",
            100,
            250
        );

        theater.AddScreening(
            "Inception",
            new DateTime(2026, 2, 2, 21, 30, 0),
            "Screen 2",
            80,
            300
        );

        theater.AddScreening(
            "Interstellar",
            new DateTime(2026, 2, 2, 20, 0, 0),
            "Screen 3",
            120,
            280
        );

        bool booked1 = theater.BookTickets(
            "Inception",
            new DateTime(2026, 2, 2, 18, 30, 0),
            5
        );

        bool booked2 = theater.BookTickets(
            "Interstellar",
            new DateTime(2026, 2, 2, 20, 0, 0),
            10
        );

        Console.WriteLine(booked1);
        Console.WriteLine(booked2);

        var grouped = theater.GroupScreeningsByMovie();
        foreach (var movie in grouped)
        {
            Console.WriteLine(movie.Key);
            foreach (var screening in movie.Value)
            {
                Console.WriteLine(screening.ShowTime + " " + screening.ScreenNumber);
            }
        }

        double revenue = theater.CalculateTotalRevenue();
        Console.WriteLine(revenue);

        var available = theater.GetAvailableScreenings(50);
        foreach (var s in available)
        {
            Console.WriteLine(s.MovieTitle + " " + s.ShowTime);
        }
    }

}