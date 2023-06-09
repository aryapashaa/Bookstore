﻿using Bookstore_API.Repositories;
using Bookstore_API.Contexts;
using Bookstore_API.Models;

namespace Bookstore_API.Repositories.Data;

public class LanguageRepository : GeneralRepository<int, Language>
{
    public LanguageRepository(MyContext context) : base(context)
    {
    }
}
