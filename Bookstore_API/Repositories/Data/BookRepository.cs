using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class BookRepository : GeneralRepository<int, Book>
{
    public BookRepository(MyContext context) : base(context)
    {
    }
}
