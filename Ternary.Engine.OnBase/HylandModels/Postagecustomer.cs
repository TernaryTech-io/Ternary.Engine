using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Postagecustomer
{
    public long Pocustomernum { get; set; }

    public string? Customername { get; set; }

    public string? Customerunit { get; set; }

    public long? Isdefault { get; set; }

    public string? Email { get; set; }
}
