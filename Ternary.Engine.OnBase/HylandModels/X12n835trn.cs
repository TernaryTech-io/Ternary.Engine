using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835trn
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Trn01tracetype { get; set; }

    public string? Trn02refid { get; set; }

    public string? Trn03origcoid { get; set; }

    public string? Trn04origcosupp { get; set; }
}
