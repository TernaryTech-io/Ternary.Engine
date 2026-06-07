using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemtypelc
{
    public long Lcnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Initialstatenum { get; set; }

    public long? Flags { get; set; }
}
