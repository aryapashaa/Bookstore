using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class ShoppingCartRepository : GeneralRepository<int, ShoppingCart>
{
    public ShoppingCartRepository(MyContext context) : base(context)
    {
    }
}
