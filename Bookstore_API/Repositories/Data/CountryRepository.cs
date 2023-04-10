using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class CountryRepository : GeneralRepository<int, Country>
{
    public CountryRepository(MyContext context) : base(context)
    {
    }
}
