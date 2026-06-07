using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwglrule
{
    public long Rcmtwglrulenum { get; set; }

    public long? Rcmtwgltypenum { get; set; }

    public string? Rcmtwglrulename { get; set; }

    public string? Ruletext { get; set; }

    public long? Criteriacount { get; set; }

    public long? Sourcetableid { get; set; }

    public long? Ordernum { get; set; }

    public long? Active { get; set; }

    public long? Flags { get; set; }
}
