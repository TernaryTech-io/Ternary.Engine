using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mergekey
{
    public long Mergenum { get; set; }

    public long? Keynum { get; set; }

    public long? Keykeytype { get; set; }

    public long? Locationx { get; set; }

    public long? Locationy { get; set; }

    public long? Width { get; set; }

    public long? Height { get; set; }
}
