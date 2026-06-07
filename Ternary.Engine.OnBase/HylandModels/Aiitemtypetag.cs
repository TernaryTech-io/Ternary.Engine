using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aiitemtypetag
{
    public long Tagnum { get; set; }

    public long? Tagsetnum { get; set; }

    public string? Tagtext { get; set; }

    public long? Tagweight { get; set; }

    public long? Fontsize { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Languagetype { get; set; }

    public string? Aggregateguid { get; set; }
}
