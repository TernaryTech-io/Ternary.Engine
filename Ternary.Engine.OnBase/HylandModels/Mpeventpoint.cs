using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpeventpoint
{
    public long Mpeventpointnum { get; set; }

    public long? Mpmedianum { get; set; }

    public long? Eventtimeoffset { get; set; }

    public long? Flags { get; set; }

    public long? Trimtimeoffset { get; set; }
}
