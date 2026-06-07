using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gipathologytype
{
    public long Gipthologytypenum { get; set; }

    public long? Giproctypenum { get; set; }

    public string? Giordercode { get; set; }

    public string? Giorderdescription { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }

    public long? Isenabled { get; set; }
}
