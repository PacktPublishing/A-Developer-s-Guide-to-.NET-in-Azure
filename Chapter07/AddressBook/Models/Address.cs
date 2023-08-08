namespace AddressBook.Models;
public class Address
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime? CreatedOn { get; set; } = DateTime.UtcNow;
}
