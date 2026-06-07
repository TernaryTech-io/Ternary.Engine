using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Localcloudcache
{
    public long Lclcloudcachenum { get; set; }

    public string? Lclcloudcachename { get; set; }

    public string? Lclcloudcachepath { get; set; }

    public long? Maxsize { get; set; }

    public long? Minsize { get; set; }

    public long? Timelimit { get; set; }

    public long? Currentsize { get; set; }

    public long? Flags { get; set; }

    public long? Maxlimithits { get; set; }
}
