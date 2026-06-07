using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ittemplxref
{
    public long Xrefitemtypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long Keytypenum { get; set; }

    public long? Line { get; set; }

    public long? Columnnum { get; set; }

    public long? Height { get; set; }

    public long? Width { get; set; }

    public long? Idkeyflag { get; set; }

    public string? Idstr { get; set; }
}
