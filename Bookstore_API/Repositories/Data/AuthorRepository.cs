using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class AuthorRepository : GeneralRepository<int, Author>
{
    public AuthorRepository(MyContext context) : base(context)
    {
    }
}
