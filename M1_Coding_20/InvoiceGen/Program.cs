using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Item itemp1 = new Item { ItemName = "item1", qty = 2, Price = 500 };
        Item itemp2 = new Item { ItemName = "item2", qty = 24, Price = 200 };
        Item itemp3 = new Item { ItemName = "item3", qty = 23, Price = 700 };
        Item itemp4 = new Item { ItemName = "item4", qty = 26, Price = 400 };
        Item itemp5 = new Item { ItemName = "item5", qty = 3, Price = 570 };

        int total =
            itemp1.qty * itemp1.Price +
            itemp2.qty * itemp2.Price +
            itemp3.qty * itemp3.Price +
            itemp4.qty * itemp4.Price +
            itemp5.qty * itemp5.Price;

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Item1 Total => {itemp1.qty * itemp1.Price}");
        sb.AppendLine($"Item2 Total => {itemp2.qty * itemp2.Price}");
        sb.AppendLine($"Item3 Total => {itemp3.qty * itemp3.Price}");
        sb.AppendLine($"Item4 Total => {itemp4.qty * itemp4.Price}");
        sb.AppendLine($"Item5 Total => {itemp5.qty * itemp5.Price}");
        sb.AppendLine($"Total => {total}");
        System.Console.WriteLine(sb.ToString());
    }
}

public class Item
{
    public string? ItemName { get; set; }
    public int qty { get; set; }
    public int Price { get; set; }
}