using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirsetting
{
    public long Fhirsettingnum { get; set; }

    public long? Fhirsettingtype { get; set; }

    public string? Fhirsettingvalue { get; set; }

    public long? Flags { get; set; }

    public long? Obblobnum { get; set; }
}
