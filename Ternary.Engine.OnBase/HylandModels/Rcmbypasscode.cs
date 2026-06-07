using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbypasscode
{
    public long Rcmbypasscodenum { get; set; }

    public string? Rcmbypassdescrption { get; set; }

    public long? Flags { get; set; }

    public long? Active { get; set; }

    public long? Externalposting { get; set; }
}
