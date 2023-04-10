using Bookstore_API.Repositories;
using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class AddressRepository : GeneralRepository<int, Address>
{
    public AddressRepository(MyContext context) : base(context)
    {
    }
}
