using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Customer
{
    public long Customernum { get; set; }

    public string? Customername { get; set; }

    public long? Customeritemnum { get; set; }

    public long? Usernum { get; set; }

    public long? Maxcustomerusers { get; set; }

    public long? Flags { get; set; }

    public string? Extcustomerid { get; set; }
}
