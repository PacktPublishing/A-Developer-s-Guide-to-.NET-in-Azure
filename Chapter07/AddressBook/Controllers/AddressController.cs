using AddressBook.Models;

using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressBookController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        throw new NotImplementedException();
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
