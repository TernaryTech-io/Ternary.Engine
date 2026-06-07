using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Addresslog
{
    public long Addresslognum { get; set; }

    public long? Addressnum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Changecolumn { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }

    public long? Changeusernum { get; set; }

    public long? Changeinitiator { get; set; }
}
