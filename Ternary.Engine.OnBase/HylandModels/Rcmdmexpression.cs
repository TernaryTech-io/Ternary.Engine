using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdmexpression
{
    public long Rcmdmexprnum { get; set; }

    public string? Exprname { get; set; }

    public string? Description { get; set; }

    public string? Expression { get; set; }

    public string? Exprnotes { get; set; }

    public long? Seqnum { get; set; }
}
