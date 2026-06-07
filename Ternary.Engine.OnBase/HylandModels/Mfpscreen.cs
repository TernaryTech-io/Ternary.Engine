using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfpscreen
{
    public long Mfpscreennum { get; set; }

    public long? Mfptransactionnum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Mfpscreentext { get; set; }

    public long? Sequencenum { get; set; }

    public long? Flags { get; set; }
}
