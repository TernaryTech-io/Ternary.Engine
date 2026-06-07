using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sigdefinition
{
    public long Siglocationnum { get; set; }

    public string? Signame { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Sigflags { get; set; }
}
