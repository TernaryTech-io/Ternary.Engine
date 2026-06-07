using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvalpath
{
    public long Approvalpathnum { get; set; }

    public long? Approvalprocnum { get; set; }

    public long? Approvalrulenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
