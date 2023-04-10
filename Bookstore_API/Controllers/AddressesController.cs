using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddressesController : BaseController<int,Address,AddressRepository>
{
    public AddressesController(AddressRepository repository) : base(repository)
    {
    }
}
