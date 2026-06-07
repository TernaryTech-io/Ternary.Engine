using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roipacketbatch
{
    public long Roipacketbatchnum { get; set; }

    public long? Roirequestnum { get; set; }

    public long? Batchstatus { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Priority { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }
}
