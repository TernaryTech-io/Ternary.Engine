using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pagereference
{
    public long Itemnum { get; set; }

    public long Docrevnum { get; set; }

    public long Pagenum { get; set; }

    public long? Firstlinenum { get; set; }

    public long? Offset { get; set; }
}
