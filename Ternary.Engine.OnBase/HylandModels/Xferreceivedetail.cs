using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferreceivedetail
{
    public long? Xferrecievenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Detailtype { get; set; }

    public string? Detaildescription { get; set; }

    public DateTime? Datemodified { get; set; }
}
