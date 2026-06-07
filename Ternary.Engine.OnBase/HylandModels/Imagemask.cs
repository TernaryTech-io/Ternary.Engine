using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Imagemask
{
    public long Imagemasknum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Masktop { get; set; }

    public long? Maskbottom { get; set; }

    public long? Maskleft { get; set; }

    public long? Maskright { get; set; }

    public long? Flags { get; set; }

    public long? Pagenum { get; set; }
}
