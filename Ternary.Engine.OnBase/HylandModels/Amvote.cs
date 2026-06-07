using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amvote
{
    public long Amvotenum { get; set; }

    public long? Motionnum { get; set; }

    public long? Ammembernum { get; set; }

    public long? Amvotechoice { get; set; }

    public long? Flags { get; set; }

    public long? Amvotetypenum { get; set; }
}
