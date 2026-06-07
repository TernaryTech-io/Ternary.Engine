using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xfersendqueue
{
    public long Xfersendnum { get; set; }

    public long? Xferpackagenum { get; set; }

    public string? Serverpackageid { get; set; }

    public long? Xfersitenum { get; set; }

    public long? Status { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Laststatusupdate { get; set; }

    public string? Xfersendname { get; set; }

    public long? Totaldocs { get; set; }

    public long? Pagecount { get; set; }

    public long? Batchnum { get; set; }

    public long? Usernum { get; set; }
}
