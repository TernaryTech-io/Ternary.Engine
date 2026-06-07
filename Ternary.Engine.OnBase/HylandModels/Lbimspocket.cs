using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimspocket
{
    public long Pocketcutnum { get; set; }

    public long? Lockboxnum { get; set; }

    public string? Pocketcutid { get; set; }

    public long? Imsbankid { get; set; }

    public long? Checkcount { get; set; }

    public decimal? Checktotal { get; set; }

    public DateTime? Consolidationdate { get; set; }

    public long? Consolidationnum { get; set; }

    public long? Consolidationid { get; set; }

    public DateTime? Cutdate { get; set; }

    public DateTime? Depositdate { get; set; }

    public long? Imsdepositid { get; set; }

    public long? Imsdepositnum { get; set; }

    public string? P2operatorid { get; set; }

    public long? P2stationid { get; set; }
}
