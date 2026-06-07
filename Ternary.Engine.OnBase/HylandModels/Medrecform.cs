using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medrecform
{
    public long Itemtypenum { get; set; }

    public long Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Pagenum { get; set; }

    public long? Xpos { get; set; }

    public long? Ypos { get; set; }
}
