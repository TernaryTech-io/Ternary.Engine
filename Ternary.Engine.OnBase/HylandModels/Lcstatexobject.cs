using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcstatexobject
{
    public long Statenum { get; set; }

    public long Objecttype { get; set; }

    public long Objectnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
