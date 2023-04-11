using Client.Models;

namespace Client.Repositories.Data;

public class ShoppingCartRepository : GeneralRepository<ShoppingCart, int>
{
    public ShoppingCartRepository(string request = "ShoppingCarts/") : base(request)
    {
    }
}
