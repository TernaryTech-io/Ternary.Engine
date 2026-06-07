using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvallevel1
{
    public long Approvallevelnum { get; set; }

    public long? Approvalpathnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Approvalrulenum { get; set; }

    public long? Approvaltype { get; set; }

    public long? Minapprovals { get; set; }

    public long? Flags { get; set; }
}
