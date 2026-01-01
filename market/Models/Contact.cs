using System;
using System.Collections.Generic;

namespace market.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Description { get; set; }
}
