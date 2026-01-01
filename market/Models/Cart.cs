using System;
using System.Collections.Generic;

namespace market.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? Userid { get; set; }

    public int? Productid { get; set; }

    public int? Amount { get; set; }

    public virtual Product? Product { get; set; }
}
