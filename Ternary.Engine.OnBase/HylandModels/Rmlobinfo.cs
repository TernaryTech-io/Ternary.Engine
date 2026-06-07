using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmlobinfo
{
    public long Lobconfigid { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectid { get; set; }

    public string? Rmdescription { get; set; }

    public long? Flags { get; set; }

    public long? Obblobnum { get; set; }
}
