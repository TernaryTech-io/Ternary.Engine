using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gisrelateddocument
{
    public long Gisrelateddocnum { get; set; }

    public long? Gisconfiglayernum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
