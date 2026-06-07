using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvalnotification1
{
    public long Approvalprocnum { get; set; }

    public long Notificationid { get; set; }

    public long Notificationtype { get; set; }

    public long Seqnum { get; set; }

    public long? Interval { get; set; }

    public long? Flags { get; set; }
}
