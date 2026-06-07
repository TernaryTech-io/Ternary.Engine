using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docretexclusion
{
    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Dateexclude { get; set; }

    public string? Reasonexclude { get; set; }
}
