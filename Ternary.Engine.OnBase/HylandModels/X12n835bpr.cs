using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835bpr
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Bpr01thcode { get; set; }

    public decimal? Bpr02amount { get; set; }

    public string? Bpr03creditflag { get; set; }

    public string? Bpr04pmtmethod { get; set; }

    public string? Bpr05pmtformat { get; set; }

    public string? Bpr06idnumberq { get; set; }

    public string? Bpr07idnumber { get; set; }

    public string? Bpr08acctnumberq { get; set; }

    public string? Bpr09acctnumber { get; set; }

    public string? Bpr10origcoid { get; set; }

    public string? Bpr11origcosupp { get; set; }

    public string? Bpr12dfiidnumberq { get; set; }

    public string? Bpr13dfiidnumber { get; set; }

    public string? Bpr14acctnumberq { get; set; }

    public string? Bpr15acctnumber { get; set; }

    public DateTime? Bpr16date { get; set; }
}
