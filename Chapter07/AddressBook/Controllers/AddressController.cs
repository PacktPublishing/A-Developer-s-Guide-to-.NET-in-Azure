using AddressBook.Data;
using AddressBook.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressBookController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var addressBookDbContextOptions = new DbContextOptionsBuilder<AddressBookDbContext>()
        .UseSqlServer("<your-azure-database-connection-string>").Options;
        using var addressBookDbContext = new AddressBookDbContext(addressBookDbContextOptions);
        var addresses = addressBookDbContext.Addresses.ToList();
        return Ok(addresses);
    }

    [HttpGet("{id}")]
    public IActionResult GetById()
    {
        throw new NotImplementedException();
    }
    [HttpPost]
    public IActionResult Post(Address address)
    {
        throw new NotImplementedException();
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, Address address)
    {
        throw new NotImplementedException();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        throw new NotImplementedException();
    }
}
