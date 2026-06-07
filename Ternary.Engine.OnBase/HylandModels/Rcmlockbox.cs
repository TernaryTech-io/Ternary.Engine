using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmlockbox
{
    public long Rcmlockboxnum { get; set; }

    public string? Lockboxcode { get; set; }

    public string? Rcmlockboxdescrption { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public long? Active { get; set; }
}
