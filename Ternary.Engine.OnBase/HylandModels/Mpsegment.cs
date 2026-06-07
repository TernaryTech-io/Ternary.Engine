using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpsegment
{
    public long? Mpsegmentsetnum { get; set; }

    public long? Actiontype { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
