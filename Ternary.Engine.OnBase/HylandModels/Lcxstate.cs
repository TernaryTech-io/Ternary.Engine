using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcxstate
{
    public long Statenum { get; set; }

    public long Lcnum { get; set; }

    public long? Xpos { get; set; }

    public long? Ypos { get; set; }

    public long? Checkvalue { get; set; }

    public long? Seqnum { get; set; }

    public long? Zindex { get; set; }

    public long? Flags { get; set; }
}
