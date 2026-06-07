using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rimevent1
{
    public long Eventtypenum { get; set; }

    public long? Eventsetnum { get; set; }

    public string? Eventtypename { get; set; }

    public string? Eventtypedesc { get; set; }

    public long? Deststatus { get; set; }

    public long? Delayinterval { get; set; }

    public long? Delayunits { get; set; }

    public long? Flags { get; set; }

    public long? Destructionflags { get; set; }

    public long? Eventinterval { get; set; }

    public long? Eventunits { get; set; }

    public long? Eventsysinterval { get; set; }
}
