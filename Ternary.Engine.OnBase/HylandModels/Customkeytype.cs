using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Customkeytype
{
    public long Keytypenum { get; set; }

    public long Cqnum { get; set; }

    public long? Keysetnum { get; set; }

    public long? Keytypesetflags { get; set; }

    public long? Cqkeytypeflags { get; set; }

    public string? Defaultkey { get; set; }

    public long? Seqnum { get; set; }
}
