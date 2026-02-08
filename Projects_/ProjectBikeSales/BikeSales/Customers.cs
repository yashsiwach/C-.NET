public class Customer
{
    public int CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

    public List<Order> Orders { get; set; } = new();
}
