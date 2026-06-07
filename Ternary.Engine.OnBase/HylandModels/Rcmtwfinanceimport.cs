using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinanceimport
{
    public long Rcmtwfinimportnum { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public DateTime? Minbatchdate { get; set; }

    public string? Arbatchprefix { get; set; }

    public long? Rcmfinancetypenum { get; set; }

    public string? Twfinancecomment { get; set; }

    public long? Active { get; set; }

    public long? Rcmimporttype { get; set; }

    public long? Flags { get; set; }
}
