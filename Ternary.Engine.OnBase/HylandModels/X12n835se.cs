using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835se
{
    public long Se835num { get; set; }

    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Se01segcount { get; set; }

    public string? Se02ctrlnumber { get; set; }
}
