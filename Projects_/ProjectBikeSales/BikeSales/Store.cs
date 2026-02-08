public class Store
{
    public int StoreId { get; set; }
    public string? StoreName { get; set; }

    public List<Staff> Staffs { get; set; } = new();
    public List<Order> Orders { get; set; } = new();
}
