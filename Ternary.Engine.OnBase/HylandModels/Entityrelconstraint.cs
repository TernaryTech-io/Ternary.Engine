using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityrelconstraint
{
    public long Entityrelcstnum { get; set; }

    public long? Etrelationshipnum { get; set; }

    public string? Etfieldaddress { get; set; }

    public long? Etoperator { get; set; }

    public long? Seqnum { get; set; }

    public string? Etrelfieldaddress { get; set; }

    public long? Flags { get; set; }
}
