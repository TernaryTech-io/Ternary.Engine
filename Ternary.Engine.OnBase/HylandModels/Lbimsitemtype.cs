using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsitemtype
{
    public long Datafileversion { get; set; }

    public long Lockboxnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Imsdocgroupid { get; set; }

    public long? Imsdoctype { get; set; }

    public long? Imsdoctypeid { get; set; }

    public string? Docname { get; set; }
}
