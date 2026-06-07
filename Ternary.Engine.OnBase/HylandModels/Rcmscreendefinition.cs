using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmscreendefinition
{
    public long Rcmscrndefnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public string? Rcmscrndefscreenid { get; set; }

    public string? Rcmscrndeffieldid { get; set; }

    public long? Rcmscrndefxcoord { get; set; }

    public long? Rcmscrndefycoord { get; set; }

    public long? Rcmscrndeflength { get; set; }

    public string? Rcmscrndeffldname { get; set; }

    public string? Rcmscrndeffldlongid { get; set; }
}
