public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int StaffId { get; set; }
    public int StoreId { get; set; }

    public Customer? Customer { get; set; }
    public Staff? Staff { get; set; }
    public Store? Store { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}
