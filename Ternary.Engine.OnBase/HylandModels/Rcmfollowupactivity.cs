using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmfollowupactivity
{
    public long Rcmfollowupactnum { get; set; }

    public string? Rcmfollowupactname { get; set; }

    public long? Rcmacttypenum { get; set; }

    public long? Rcmworklistnum { get; set; }

    public long? Rcmhostpostpolnum { get; set; }

    public long? Isactive { get; set; }

    public long? Appealsuspendnodays { get; set; }

    public long? Isclosingactivity { get; set; }

    public long? Templateid { get; set; }
}
