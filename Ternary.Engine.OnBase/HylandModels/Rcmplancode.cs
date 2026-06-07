using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmplancode
{
    public long Rcmplancodenum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public string? Rcmplancode1 { get; set; }

    public long? Active { get; set; }
}
