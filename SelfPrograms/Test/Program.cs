using System;
using System.Collections.Generic;
using System.Linq;

public class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int PricePerDay { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        if (!Program.bikeDetails.ContainsKey(Program.unique))
        {
            Program.bikeDetails[Program.unique++] =
                new Bike { Model = model, Brand = brand, PricePerDay = pricePerDay };
        }
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> ans = new SortedDictionary<string, List<Bike>>();
        var temp = Program.bikeDetails.GroupBy(x => x.Value.Brand).ToList();

        foreach (var i in temp)
        {
            ans[i.Key] = i.Select(x => x.Value).ToList();
        }
        return ans;
    }
}

public class Program
{
    public static int unique = 0;
    public static SortedDictionary<int, Bike> bikeDetails=new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike ");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter brand");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int price = int.Parse(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);
                Console.WriteLine("Bike  added ");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                var result = utility.GroupBikesByBrand();
                foreach (var entry in result)
                {
                    Console.WriteLine(entry.Key);
                    foreach (var bike in entry.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}
