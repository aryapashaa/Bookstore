using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CitiesController : BaseController<int, City, CityRepository>
{
    public CitiesController(CityRepository repository) : base(repository)
    {
    }
}
