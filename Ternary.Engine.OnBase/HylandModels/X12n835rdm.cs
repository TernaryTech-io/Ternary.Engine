using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835rdm
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Rdm01transmitcode { get; set; }

    public string? Rdm02name { get; set; }

    public string? Rdm03commnumberq { get; set; }
}
