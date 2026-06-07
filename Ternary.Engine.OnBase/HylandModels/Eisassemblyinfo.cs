using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eisassemblyinfo
{
    public long Eisassemblynum { get; set; }

    public string? Eisassemblyname { get; set; }

    public long? Datatype { get; set; }

    public long? Obblobnum { get; set; }

    public string? Hashcode { get; set; }
}
