using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbcustevent
{
    public long Lbcusteventnum { get; set; }

    public long? Customernum { get; set; }

    public long? Lbeventnum { get; set; }

    public string? Email { get; set; }

    public long? Lbcusteventtype { get; set; }

    public long? Lockboxnum { get; set; }
}
