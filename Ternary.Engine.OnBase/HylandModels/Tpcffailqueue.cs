using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcffailqueue
{
    public long Itemnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Priority { get; set; }

    public long? Failstatus { get; set; }

    public DateTime? Dateadded { get; set; }
}
