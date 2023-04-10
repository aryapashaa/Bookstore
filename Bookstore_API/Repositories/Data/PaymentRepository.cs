using Bookstore_API.Repositories;
using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class PaymentRepository : GeneralRepository<int, Payment>
{
    public PaymentRepository(MyContext context) : base(context)
    {
    }
}
