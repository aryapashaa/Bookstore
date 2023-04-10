using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class AccountRoleRepository : GeneralRepository<int, AccountRole>
{
    public AccountRoleRepository(MyContext context) : base(context)
    {
    }
}
