public class Staff
{
    public int StaffId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool IsAdmin { get; set; }
    public int StoreId { get; set; }

    public Store? Store { get; set; }
}
