using System;

public class Program
{
    public static void Main()
    {
        // Hardcoded Stores
        Store store1 = new Store { StoreId = 1, StoreName = "Downtown Bikes" };
        Store store2 = new Store { StoreId = 2, StoreName = "City Cycles" };
        Data.Stores.Add(store1);
        Data.Stores.Add(store2);

        // Hardcoded Staff
        Staff staff1 = new Staff { StaffId = 1, FirstName = "John", LastName = "Doe", StoreId = 1, Store = store1 };
        Staff staff2 = new Staff { StaffId = 2, FirstName = "Jane", LastName = "Smith", StoreId = 2, Store = store2 };
        Data.Staffs.Add(staff1);
        Data.Staffs.Add(staff2);
        store1.Staffs.Add(staff1);
        store2.Staffs.Add(staff2);

        // Hardcoded Customers
        Customer cust1 = new Customer { CustomerId = 1, FirstName = "Mike", LastName = "Brown", Email = "mike@email.com", Password = "mike123" };
        Customer cust2 = new Customer { CustomerId = 2, FirstName = "Sara", LastName = "Wilson", Email = "sara@email.com", Password = "sara123" };
        Data.Customers.Add(cust1);
        Data.Customers.Add(cust2);

       
        Console.WriteLine("CUSTOMER LOGIN");
        Console.Write("Email: ");
        string? email = Console.ReadLine();
        Console.Write("Password: ");
        string? password = Console.ReadLine();

        Customer? customer = Data.Customers.Find(c => c.Email == email && c.Password == password);

        if (customer == null)
        {
            Console.WriteLine("Invalid login!");
            return;
        }

        Console.WriteLine($"\nWelcome, {customer.FirstName}!\n");

        // Show stores
        Console.WriteLine("Available Stores:");
        foreach (var s in Data.Stores)
            Console.WriteLine($"  {s.StoreId}. {s.StoreName}");

        Console.Write("\nSelect Store ID: ");
        int.TryParse(Console.ReadLine(), out int storeId);
        Store? store = Data.Stores.Find(s => s.StoreId == storeId);

        if (store == null)
        {
            Console.WriteLine("Invalid store!");
            return;
        }

        Staff? staff = store.Staffs.Count > 0 ? store.Staffs[0] : Data.Staffs[0];

        // Create order
        Order order = new Order
        {
            OrderId = 1,
            CustomerId = customer.CustomerId,
            StaffId = staff.StaffId,
            StoreId = store.StoreId,
            Customer = customer,
            Staff = staff,
            Store = store
        };

        Console.Write("Number of items: ");
        int.TryParse(Console.ReadLine(), out int n);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Item {i + 1} - Product ID: ");
            int.TryParse(Console.ReadLine(), out int pid);
            Console.Write($"Item {i + 1} - Quantity: ");
            int.TryParse(Console.ReadLine(), out int qty);
            Console.Write($"Item {i + 1} - Price: ");
            decimal.TryParse(Console.ReadLine(), out decimal price);

            order.OrderItems.Add(new OrderItem { ItemId = i + 1, ProductId = pid, Quantity = qty, Price = price });
        }

        Data.Orders.Add(order);

        Console.WriteLine("\n=== ORDER COMPLETE ===");
        Console.WriteLine($"Store: {store.StoreName}");
        Console.WriteLine($"Staff: {staff.FirstName} {staff.LastName}");
        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"Items: {order.OrderItems.Count}");
        Console.WriteLine($"Total: {order.OrderItems.Sum(x => x.Price * x.Quantity):C}");
    }
}
