using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class ProfileRepository : GeneralRepository<int, Profile>
{
    public ProfileRepository(MyContext context) : base(context)
    {
    }
}
