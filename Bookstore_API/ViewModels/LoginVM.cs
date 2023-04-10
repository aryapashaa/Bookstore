﻿using System.ComponentModel.DataAnnotations;

namespace Bookstore_API.ViewModels;

public class LoginVM
{
    [EmailAddress]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
