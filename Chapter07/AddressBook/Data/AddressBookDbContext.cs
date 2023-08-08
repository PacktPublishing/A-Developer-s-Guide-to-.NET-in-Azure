using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data;
public class AddressBookDbContext: DbContext
{
    public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options) 
        : base(options)
    {
    }
    public DbSet<Address> Addresses { get; set; } = null!;
}
