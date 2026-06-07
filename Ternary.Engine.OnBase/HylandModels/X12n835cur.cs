using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835cur
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Cur01entityid { get; set; }

    public string? Cur02curcode { get; set; }

    public string? Cur03exchrate { get; set; }
}
