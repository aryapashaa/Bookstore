using Bookstore_API.Base;
using Bookstore_API.Models;
using Bookstore_API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RolesController : BaseController<int, Role, RoleRepository>
{
    public RolesController(RoleRepository repository) : base(repository)
    {
    }
}
