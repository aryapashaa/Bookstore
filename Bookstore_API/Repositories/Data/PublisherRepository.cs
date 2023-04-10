using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class PublisherRepository : GeneralRepository<int, Publisher>
{
    public PublisherRepository(MyContext context) : base(context)
    {
    }
}
