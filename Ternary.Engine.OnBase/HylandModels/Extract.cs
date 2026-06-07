using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Extract
{
    public long Extractnum { get; set; }

    public string? Extractname { get; set; }

    public long? Vbscriptnum { get; set; }

    public long? Flags { get; set; }

    public string? Fullfilepath { get; set; }
}
