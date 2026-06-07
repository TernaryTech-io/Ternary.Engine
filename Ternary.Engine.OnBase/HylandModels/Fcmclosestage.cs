using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmclosestage
{
    public long Fcstagenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Fccloseeventnum { get; set; }

    public string? Fcname { get; set; }

    public DateTime? Fcstagedate { get; set; }

    public long? Fcstagetemplnum { get; set; }

    public long? Flags { get; set; }
}
