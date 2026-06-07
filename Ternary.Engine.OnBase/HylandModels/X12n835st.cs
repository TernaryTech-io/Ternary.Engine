using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835st
{
    public long St835num { get; set; }

    public long? Batchnum { get; set; }

    public long? Gs835num { get; set; }

    public long? Segposition { get; set; }

    public string? St01setid { get; set; }

    public string? St02ctrlnumber { get; set; }
}
