using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835ge
{
    public long Ge835num { get; set; }

    public long? Batchnum { get; set; }

    public long? Gs835num { get; set; }

    public long? Ge01setcount { get; set; }

    public string? Ge02ctrlnumber { get; set; }
}
