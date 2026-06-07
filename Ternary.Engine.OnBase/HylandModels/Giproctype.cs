using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giproctype
{
    public long Giproctypenum { get; set; }

    public string? Proctype { get; set; }

    public long? Flags { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Giordercode { get; set; }

    public string? Giorderdescription { get; set; }

    public string? Systemname { get; set; }

    public long? Isreporting { get; set; }

    public long? Maxvideolength { get; set; }
}
