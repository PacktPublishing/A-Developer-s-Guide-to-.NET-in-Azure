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
    public IActionResult GetById(int id)
    {
        var address = _addressBookDbContext.Addresses.Find(id);
        if (address == null)
        {
            return NotFound();
        }
        return Ok(address);
    }

    [HttpPost]
    public IActionResult Post(Address address)
    {
        _addressBookDbContext.Addresses.Add(address);
        _addressBookDbContext.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = address.Id }, address);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Address address)
    {
        if (id != address.Id)
        {
            return BadRequest();
        }
        var existingAddress = _addressBookDbContext.Addresses.Find(id);
        if (existingAddress == null)
        {
            return NotFound();
        }
        existingAddress.Name = address.Name;
        existingAddress.Email = address.Email;
        _addressBookDbContext.Update(existingAddress);
        _addressBookDbContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var book = _addressBookDbContext.Addresses.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        _addressBookDbContext.Addresses.Remove(book);
        _addressBookDbContext.SaveChanges();
        return NoContent();
    }
}
