using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Oaserver
{
    public long Oaservernum { get; set; }

    public string? Oboaservername { get; set; }

    public string? Oaservername { get; set; }

    public string? Oavolumelistname { get; set; }

    public long? Oaport { get; set; }

    public string? Oausername { get; set; }

    public string? Oapassword { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Idletimeout { get; set; }

    public long? Flags { get; set; }
}
