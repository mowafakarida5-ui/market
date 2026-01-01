using System;
using System.Collections.Generic;

namespace market.Models;

public partial class Actor
{
    public int Id { get; set; }

    public string? Admin { get; set; }

    public int? Userid { get; set; }
}
