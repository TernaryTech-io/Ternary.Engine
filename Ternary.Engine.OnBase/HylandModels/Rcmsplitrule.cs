using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitrule
{
    public long Splitrulenum { get; set; }

    public long? Splitrulesetnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Matchtype { get; set; }

    public long? X12element { get; set; }

    public string? X12loop { get; set; }

    public long? Exlusionrule { get; set; }

    public long? Iscasesensitive { get; set; }

    public string? Regexvalue { get; set; }

    public decimal? Numericmatchfrom { get; set; }

    public decimal? Numericmatchto { get; set; }

    public DateTime? Datematchfrom { get; set; }

    public DateTime? Datematchto { get; set; }

    public long? Rcmsplitdepsegnum { get; set; }

    public long? Isfielddepsegment { get; set; }

    public long? Globalrule { get; set; }

    public string? Splitrulename { get; set; }
}
