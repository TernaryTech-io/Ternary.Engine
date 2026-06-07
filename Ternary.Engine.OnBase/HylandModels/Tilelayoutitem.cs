using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tilelayoutitem
{
    public long Tilenum { get; set; }

    public long? Tilelayoutnum { get; set; }

    public long? Usernum { get; set; }

    public string? Tiletitle { get; set; }

    public string? Tiledesc { get; set; }

    public string? Tileparams { get; set; }

    public long? Tiletype { get; set; }

    public long? Tilerow { get; set; }

    public long? Tilecol { get; set; }

    public long? Tilecolor { get; set; }

    public long? Flags { get; set; }

    public DateTime? Updatedtime { get; set; }
}
