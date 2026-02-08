using System.Runtime.InteropServices;

/// <summary>
/// Interface representing a hotel room.
/// Defines billing and membership-related operations.
/// </summary>
public interface IRoom
{
    /// <summary>
    /// Calculates the total bill for a room based on
    /// nights stayed and membership joining year.
    /// </summary>
    /// <param name="nightsStayed">Number of nights stayed</param>
    /// <param name="joiningYear">Year the customer joined</param>
    /// <returns>Total bill amount</returns>
    public double calculateTotalBill(int nightsStayed, int joiningYear);

    /// <summary>
    /// Calculates the total membership duration in years
    /// based on the joining year.
    /// </summary>
    /// <param name="joiningYear">Year the customer joined</param>
    /// <returns>Membership duration in years</returns>
    int calculateMembershipYears(int joiningYear)
    {
        var now = DateTime.Now;
        return now.Year - joiningYear;
    }
}

/// <summary>
/// Represents a hotel room implementation
/// with room details and billing logic.
/// </summary>
public class HotelRoom : IRoom
{
    /// <summary>
    /// Type of the room (Deluxe or Suite).
    /// </summary>
    public String roomType;

    /// <summary>
    /// Rate charged per night.
    /// </summary>
    public double ratePerNight;

    /// <summary>
    /// Name of the guest staying in the room.
    /// </summary>
    public String guestName;

    /// <summary>
    /// Initializes a new hotel room with details.
    /// </summary>
    /// <param name="roomType">Room category</param>
    /// <param name="ratePerNight">Nightly rate</param>
    /// <param name="guestName">Guest name</param>
    public HotelRoom(string roomType, double ratePerNight, string guestName)
    {
        this.ratePerNight = ratePerNight;
        this.roomType = roomType;
        this.guestName = guestName;
    }

    /// <summary>
    /// Calculates the total room bill based on
    /// number of nights stayed.
    /// </summary>
    /// <param name="nightsStayed">Number of nights</param>
    /// <param name="joiningYear">Membership joining year</param>
    /// <returns>Rounded total bill amount</returns>
    public double calculateTotalBill(int nightsStayed, int joiningYear)
    {
        double tot = nightsStayed * ratePerNight;
        return Math.Round(tot);
    }
}

/// <summary>
/// Program execution class.
/// Handles user input and displays billing details.
/// </summary>
public class Program
{
    /// <summary>
    /// Application entry point.
    /// Takes room choice, guest details,
    /// calculates bill, and applies membership discount.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    public static void Main(string[] args)
    {
        System.Console.WriteLine("which room you like Deluxe(1) or Suite(2)");

        int choice = int.Parse(Console.ReadLine()!);

        if (choice == 1)
        {
            System.Console.WriteLine("Enter Deluxe Room Details:");
            System.Console.WriteLine("Guest Name:");
            string? guestName = Console.ReadLine();

            System.Console.WriteLine("Rate per Night:");
            double ratePerNight = double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Nights Stayed:");
            int nightsStayed = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Joining Year:");
            int joiningYear = int.Parse(Console.ReadLine()!);

            IRoom hotelRoom = new HotelRoom("Deluxe", ratePerNight, guestName);

            double tot = hotelRoom.calculateTotalBill(nightsStayed, joiningYear);
            int stayTime = hotelRoom.calculateMembershipYears(joiningYear);

            if (stayTime > 3)
            {
                tot = tot - tot * 0.1;
            }

            System.Console.WriteLine($"Deluxe room: {guestName}, {ratePerNight} per Night, Membership :{stayTime}");
            System.Console.WriteLine($"For {guestName} (Deluxe) : {tot}");
        }
        else
        {
            System.Console.WriteLine("Enter Suite Room Details:");
            System.Console.WriteLine("Guest Name:");
            string? guestName = Console.ReadLine();

            System.Console.WriteLine("Rate per Night:");
            double ratePerNight = double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Nights Stayed:");
            int nightsStayed = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Joining Year:");
            int joiningYear = int.Parse(Console.ReadLine()!);

            IRoom hotelRoom = new HotelRoom("Suite", ratePerNight, guestName);

            double tot = hotelRoom.calculateTotalBill(nightsStayed, joiningYear);
            int stayTime = hotelRoom.calculateMembershipYears(joiningYear);

            if (stayTime > 3)
            {
                tot = tot - tot * 0.1;
            }

            System.Console.WriteLine($"Suite room: {guestName}, {ratePerNight} per Night, Membership :{stayTime}");
            System.Console.WriteLine($"For {guestName} (Suite) : {tot}");
        }
    }
}
