using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfptransaction
{
    public long Mfptransactionnum { get; set; }

    public string? Mfptransname { get; set; }

    public string? Mfptranstitle { get; set; }

    public long? Queuenum { get; set; }

    public long? Flags { get; set; }
}
