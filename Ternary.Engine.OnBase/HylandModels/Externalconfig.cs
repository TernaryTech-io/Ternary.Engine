using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalconfig
{
    public long Externalconfignum { get; set; }

    public long? Configtype { get; set; }

    public string? Configxml { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
