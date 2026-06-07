using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammeetingxmember
{
    public long Ammeetingnum { get; set; }

    public long Ammembernum { get; set; }

    public long Amrolenum { get; set; }

    public long? Flags { get; set; }

    public long? Status { get; set; }

    public long? Seqnum { get; set; }
}
