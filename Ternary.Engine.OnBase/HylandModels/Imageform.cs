using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Imageform
{
    public long Imageformnum { get; set; }

    public string? Formname { get; set; }

    public long? Formflags { get; set; }

    public long? Maxformrev { get; set; }

    public long? Itemtypenum { get; set; }
}
