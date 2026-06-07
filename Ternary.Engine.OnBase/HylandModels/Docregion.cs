using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docregion
{
    public long Docregionnum { get; set; }

    public string? Docregionname { get; set; }

    public long? Docviewnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Pagenum { get; set; }

    public long? Xpos { get; set; }

    public long? Ypos { get; set; }

    public long? Regionwidth { get; set; }

    public long? Regionheight { get; set; }

    public long? Regionunits { get; set; }

    public long? Invertflag { get; set; }

    public long? Rotationflag { get; set; }

    public long? Flags { get; set; }
}
