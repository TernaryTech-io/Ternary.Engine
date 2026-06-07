using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcapturecode
{
    public long Codeitemnum { get; set; }

    public long? Claimitemnum { get; set; }

    public long? Clmdetailitemnum { get; set; }

    public long? Codetype { get; set; }

    public string? Codeabbreviation { get; set; }

    public string? Codedefinition { get; set; }
}
