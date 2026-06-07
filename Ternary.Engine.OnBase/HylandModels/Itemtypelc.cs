using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtypelc
{
    public long Lcnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Initialstatenum { get; set; }
}
