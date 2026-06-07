using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Spsblaqaction
{
    public long Spsblaqactionnum { get; set; }

    public long? Spswebnum { get; set; }

    public string? Spssiteguid { get; set; }

    public long? Spscthashnum { get; set; }

    public long? Blaqprocessnum { get; set; }

    public long? Actiontype { get; set; }

    public string? Actionguidvalue { get; set; }

    public long? Flags { get; set; }
}
