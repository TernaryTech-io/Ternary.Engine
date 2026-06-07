using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medpopfilterconfig
{
    public long Fieldnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Medpopfilterenabled { get; set; }

    public long? Flags { get; set; }

    public long Iskeyword { get; set; }
}
