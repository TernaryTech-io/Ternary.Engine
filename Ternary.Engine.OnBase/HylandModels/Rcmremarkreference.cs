using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmremarkreference
{
    public long Rcmrmkrefnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public long? Rcmrmkmasternum { get; set; }

    public long? Rcmactionnum { get; set; }

    public string? Remarkcode { get; set; }

    public string? Rcmcomments { get; set; }

    public long? Rmkpostingpriority { get; set; }

    public long? Rcmdmrmkctgmstnum { get; set; }

    public long? Rcmdmrulegrpnum { get; set; }
}
