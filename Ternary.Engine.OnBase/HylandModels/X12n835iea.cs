using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835iea
{
    public long Iea835num { get; set; }

    public long? Batchnum { get; set; }

    public long? Isa835num { get; set; }

    public long? Iea01groupcount { get; set; }

    public string? Iea02ctrlnumber { get; set; }
}
