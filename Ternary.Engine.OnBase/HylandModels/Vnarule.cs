using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnarule
{
    public long Vnarulenum { get; set; }

    public long? Vnarulesetnum { get; set; }

    public long? Dicomtagnum { get; set; }

    public string? Tagvalue { get; set; }

    public long? Tagoperator { get; set; }

    public long? Flags { get; set; }
}
