using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iemap
{
    public long? Solutioninfonum { get; set; }

    public string? Objectguid { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectnum { get; set; }

    public long? Flags { get; set; }

    public DateTime? Datestored { get; set; }
}
