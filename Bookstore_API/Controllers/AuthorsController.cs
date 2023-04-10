using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : BaseController<int, Author, AuthorRepository>
{
    public AuthorsController(AuthorRepository repository) : base(repository)
    {
    }
}
