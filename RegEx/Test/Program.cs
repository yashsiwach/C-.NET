public class Jewellery
{
    public string? Id { get; set; }
    public string? Type { get; set; }
    public string? Material { get; set; }
    public int Price { get; set; }
}
public class JewelleryUtility
{
    public Dictionary<string, string> GetJewelleryDetails(string id)
    {
        return Program.jewelleryDetails.Where(x => x.Value.Id == id).ToDictionary(g => g.Value.Id!, g => g.Value.Type!);
    }
    public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price)
    {
        var temp = Program.jewelleryDetails.Where(x => x.Value.Id == id).ToList();
        temp[0].Value.Price = price;
        return Program.jewelleryDetails.ToDictionary(g => g.Value.Id!, g => g.Value);


    }
}
public class Program
{
    public static Dictionary<int, Jewellery> jewelleryDetails = new();
    public static void Main(string[] args)
    {
        JewelleryUtility ju = new JewelleryUtility();
        jewelleryDetails[1] = new Jewellery { Id = "j1", Type = "necklace", Material = "gold", Price = 2399 };
        jewelleryDetails[2] = new Jewellery { Id = "j2", Type = "bracelet", Material = "silver", Price = 299 };
        jewelleryDetails[14] = new Jewellery { Id = "j4", Type = "necklace", Material = "gold", Price = 560 };
        int count = 0;

        while (count != 3)
        {
            Console.WriteLine("1. Get Jewellery Details\n2. Update Price\n3. Exit");
            count = int.Parse(Console.ReadLine()!);
            if (count == 1)
            {
                Console.WriteLine("enter id");
                string? id = Console.ReadLine();
                var data = ju.GetJewelleryDetails(id!);
                if (data.Count == 0)
                {
                    Console.WriteLine("not found");
                }
                foreach (var i in data)
                {
                    Console.WriteLine(i.Key + " " + i.Value);
                }

            }
            else if (count == 2)
            {
                Console.WriteLine("enter price");

                Console.WriteLine("enter id");

                int newprice = int.Parse(Console.ReadLine()!);
                string? id = Console.ReadLine();
                var res = ju.UpdateJewelleryPrice(id!, newprice);
                if (res.Count == 0)
                {
                    Console.WriteLine("not found");
                }
                foreach (var i in res)
                {
                    Console.WriteLine(i.Key + " " + i.Value.Price);
                }
            }
            else
            {
                Console.WriteLine("thankyou");
            }

        }
    }
}
