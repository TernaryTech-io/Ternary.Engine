using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prfpacket
{
    public long Prfpacketnum { get; set; }

    public string? Prfpacketname { get; set; }

    public long? Flags { get; set; }

    public long? Prfpackettype { get; set; }

    public long? Prfpacketisdisabled { get; set; }
}
