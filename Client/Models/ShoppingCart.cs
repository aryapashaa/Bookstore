﻿namespace Client.Models;
public class ShoppingCart
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ProfileId { get; set; }
    public int BookId { get; set; }
}
