using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Admin")]
public class CountriesController : BaseController<int, Country, CountryRepository>
{
    public CountriesController(CountryRepository repository) : base(repository)
    {
    }
}
