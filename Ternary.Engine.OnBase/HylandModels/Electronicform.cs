using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Electronicform
{
    public long Itemtypenum { get; set; }

    public long Itrevnum { get; set; }

    public long? Formitemnum { get; set; }

    public long? Formflags { get; set; }

    public long? Maxitrevnum { get; set; }
}
