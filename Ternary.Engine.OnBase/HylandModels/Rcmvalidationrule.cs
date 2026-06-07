using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmvalidationrule
{
    public long Rcmvalrulenum { get; set; }

    public string? Rcmvalrulename { get; set; }

    public string? Rcmruleprocname { get; set; }

    public long? Contexttype { get; set; }

    public long? Rcmruletypeflag { get; set; }

    public long? Rcmlevel { get; set; }
}
