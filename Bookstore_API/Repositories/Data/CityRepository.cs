using Bookstore_API.Repositories;
using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class CityRepository : GeneralRepository<int, City>
{
    public CityRepository(MyContext context) : base(context)
    {
    }
}
