using System;
using System.Collections.Generic;
using System.Linq;

public class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
}

public class HotelManager
{
    public void AddRoom(int roomNumber, string type, double price)
    {
        Program.data.Add(new Room
        {
            RoomNumber = roomNumber,
            RoomType = type,
            PricePerNight = price,
            IsAvailable = true
        });
    }

    public Dictionary<string, List<Room>> GroupRoomsByType()
    {
        return Program.data
            .GroupBy(x => x.RoomType)
            .ToDictionary(a => a.Key, a => a.ToList());
    }

    public bool BookRoom(int roomNumber, int nights)
    {
        var room = Program.data.FirstOrDefault(
            x => x.RoomNumber == roomNumber && x.IsAvailable
        );

        if (room == null)
            return false;

        room.IsAvailable = false;
        double totalCost = room.PricePerNight * nights;
        return true;
    }

    public List<Room> GetAvailableRoomsByPriceRange(double min, double max)
    {
        return Program.data
            .Where(x => x.IsAvailable && x.PricePerNight >= min && x.PricePerNight <= max)
            .ToList();
    }
}

public class Program
{
    public static List<Room> data = new List<Room>();

    public static void Main(string[] args)
    {
        HotelManager manager = new HotelManager();

        manager.AddRoom(101, "Deluxe", 3000);
        manager.AddRoom(102, "Deluxe", 3200);
        manager.AddRoom(201, "Suite", 5000);

        bool booked = manager.BookRoom(101, 3);
        Console.WriteLine(booked ? "Room booked" : "Booking failed");

        var grouped = manager.GroupRoomsByType();
        foreach (var g in grouped)
        {
            Console.WriteLine(g.Key);
            foreach (var r in g.Value)
            {
                Console.WriteLine($"{r.RoomNumber} {r.IsAvailable}");
            }
        }

        var available = manager.GetAvailableRoomsByPriceRange(2500, 4000);
        foreach (var r in available)
        {
            Console.WriteLine($"Available: {r.RoomNumber}");
        }
    }
}