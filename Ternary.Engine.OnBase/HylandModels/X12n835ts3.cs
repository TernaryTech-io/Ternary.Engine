using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835ts3
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Lx835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Ts301refid { get; set; }

    public string? Ts302facilitycode { get; set; }

    public string? Ts303date { get; set; }

    public long? Ts304claimcount { get; set; }

    public decimal? Ts305claimamt { get; set; }

    public decimal? Ts313amount { get; set; }

    public decimal? Ts315amount { get; set; }

    public decimal? Ts317amount { get; set; }

    public decimal? Ts318amount { get; set; }

    public decimal? Ts320amount { get; set; }

    public decimal? Ts321amount { get; set; }

    public decimal? Ts322amount { get; set; }

    public decimal? Ts323pipclaimcount { get; set; }

    public decimal? Ts324pipclaimamt { get; set; }
}
