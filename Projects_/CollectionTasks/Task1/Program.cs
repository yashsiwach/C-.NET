public class Program
{
    // Stores item name as key and sold count as value (sorted by key)
    public static SortedDictionary<String, long> itemDetails =
        new SortedDictionary<string, long>();

    public static void Main(string[] args)
    {
        // Adding sample data to dictionary
        itemDetails.Add("test1", 30);
        itemDetails.Add("Test2", 10);
        itemDetails.Add("test3", 49);

        // Asking user for sold count input
        System.Console.WriteLine("Enter the SoldCount");
        int soldCount = int.Parse(Console.ReadLine()!);

        Program obj = new Program();

        // Find items whose sold count is greater than input
        var filtered = obj.FindItemDetails(soldCount);

        // Printing filtered items
        if (filtered != null)
        {
            filtered.ToList().ForEach(
                x => System.Console.WriteLine(x.Key + " " + x.Value)
            );
        }
        else
        {
            System.Console.WriteLine("Invaild SOld Count");
        }

        // Finding item with minimum and maximum sold count
        var miniAndMaxi = obj.FindMinandMaxSoldItems();

        // Printing min and max item names
        miniAndMaxi.ForEach(x => System.Console.Write(x + " "));
        System.Console.WriteLine();

        // Sorting items based on sold count
        var sorted = obj.SortByCount();

        // Printing sorted result
        if (sorted != null)
        {
            sorted.ToList().ForEach(
                x => System.Console.WriteLine(x.Key + " " + x.Value)
            );
        }
        else
        {
            System.Console.WriteLine("Empty");
        }
    }

    // Returns items whose sold count is greater than given value
    public SortedDictionary<String, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<String, long> temp =
            new SortedDictionary<string, long>();

        foreach (var i in itemDetails)
        {
            // Check if item sold count is greater than input
            if (i.Value > soldCount)
            {
                temp[i.Key] = i.Value;
            }
        }
        return temp;
    }

    // Finds and returns item names with minimum and maximum sold count
    public List<String> FindMinandMaxSoldItems()
    {
        List<String> temp = new List<string>();

        String maxiString = "";
        String miniString = "";

        long maxiValue = 0;
        long miniValue = int.MaxValue;

        // Finding minimum sold item
        foreach (var i in itemDetails)
        {
            if (i.Value < miniValue)
            {
                miniValue = i.Value;
                miniString = i.Key;
            }
        }

        // Finding maximum sold item
        foreach (var i in itemDetails)
        {
            if (i.Value > maxiValue)
            {
                maxiValue = i.Value;
                maxiString = i.Key;
            }
        }

        // Adding min and max item names to list
        temp.Add(miniString);
        temp.Add(maxiString);

        return temp;
    }

    // Sorts items based on sold count (value)
    public Dictionary<String, long> SortByCount()
    {
        Dictionary<String, long> dict =
            new Dictionary<string, long>();

        // Sorting dictionary by value using LINQ
        var sorted = itemDetails.OrderBy(x => x.Value);

        foreach (var i in sorted)
        {
            dict[i.Key] = i.Value;
        }
        return dict;
    }
}
