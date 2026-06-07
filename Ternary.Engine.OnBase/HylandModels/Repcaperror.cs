using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repcaperror
{
    public long Rcerrornum { get; set; }

    public long? Rcbatchnum { get; set; }

    public long? Rcrequestnum { get; set; }

    public long? Rcdocumentnum { get; set; }

    public long? Rccode { get; set; }

    public string? Rcdata { get; set; }

    public long? Seqnum { get; set; }

    public DateTime? Rctimestamp { get; set; }
}
