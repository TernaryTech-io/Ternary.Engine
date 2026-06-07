using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnaxtag
{
    public long Vnaxtagnum { get; set; }

    public long? Parenttagnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Vnastudynum { get; set; }

    public long? Vnaseriesnum { get; set; }

    public long? Vnainstancenum { get; set; }

    public long? Dicomtaggroup { get; set; }

    public long? Dicomtagelement { get; set; }

    public string? Dicomxtagvalue { get; set; }

    public long Vnarevnum { get; set; }

    public long? Vnarevstatus { get; set; }

    public long? Vnarevreason { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Dicomlevel { get; set; }

    public long? Flags { get; set; }
}
