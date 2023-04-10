using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class RoleRepository : GeneralRepository<int, Role>
{
    public RoleRepository(MyContext context) : base(context)
    {
    }
}
