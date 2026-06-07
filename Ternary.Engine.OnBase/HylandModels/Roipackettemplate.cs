using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roipackettemplate
{
    public long Roipackettmpltnum { get; set; }

    public string? Templatename { get; set; }

    public long? Printformatnum { get; set; }

    public long? Flags { get; set; }
}
