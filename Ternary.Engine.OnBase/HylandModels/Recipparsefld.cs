using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Recipparsefld
{
    public long Parsefilenum { get; set; }

    public long Keytypenum { get; set; }

    public long? Ordernum { get; set; }

    public string? Defaultvalue { get; set; }
}
