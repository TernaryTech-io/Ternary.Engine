using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmworklistcommon
{
    public long Rcmwlcommonnum { get; set; }

    public long? Rcmworklistnum { get; set; }

    public long? Rcmworklistreasonnum { get; set; }

    public long? Rcmwlstatus { get; set; }

    public long? Lasthistorynum { get; set; }

    public long? Assignedbyusernum { get; set; }

    public DateTime? Assigneddate { get; set; }

    public long? Assignedtousernum { get; set; }

    public long? Assignedtogrpnum { get; set; }

    public DateTime? Unsuspenddate { get; set; }
}
