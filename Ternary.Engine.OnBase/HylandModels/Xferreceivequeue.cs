using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferreceivequeue
{
    public long Xferrecievenum { get; set; }

    public DateTime? Datereceived { get; set; }

    public long? Xferpackagenum { get; set; }

    public long? Xfersitenum { get; set; }

    public long? Status { get; set; }

    public DateTime? Laststatusupdate { get; set; }

    public string? Xferreceivename { get; set; }

    public long? Totaldocs { get; set; }

    public long? Pagecount { get; set; }

    public long? Batchnum { get; set; }

    public long? Usernum { get; set; }

    public long? Remotequeueid { get; set; }
}
