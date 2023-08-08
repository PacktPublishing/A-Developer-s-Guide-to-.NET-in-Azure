using AddressBook.Data;
using AddressBook.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressBookController : ControllerBase
{
    private readonly AddressBookDbContext _addressBookDbContext;

    public AddressBookController(AddressBookDbContext addressBookDbContext)
    {
        _addressBookDbContext = addressBookDbContext;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var addresses = _addressBookDbContext.Addresses.ToList();
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
