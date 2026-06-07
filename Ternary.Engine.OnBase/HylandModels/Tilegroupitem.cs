using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tilegroupitem
{
    public long Tilegroupitemnum { get; set; }

    public long? Tilegroupnum { get; set; }

    public string? Tiletitle { get; set; }

    public string? Tiledesc { get; set; }

    public long? Tiletype { get; set; }

    public long? Tilerow { get; set; }

    public long? Tilecol { get; set; }

    public long? Tilecolor { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Updatedtime { get; set; }

    public long? Flags { get; set; }
}
