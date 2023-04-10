using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishersController : BaseController<int, Publisher, PublisherRepository>
{
    public PublishersController(PublisherRepository repository) : base(repository)
    {
    }
}
