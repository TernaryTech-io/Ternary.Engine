using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammotiontype
{
    public long Motiontypenum { get; set; }

    public string? Motiontypename { get; set; }

    public long? Flags { get; set; }

    public string? Amdefaulttext { get; set; }

    public long? Seqnum { get; set; }
}
