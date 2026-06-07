using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Voterlog
{
    public long Voterlognum { get; set; }

    public long? Voternum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Changecolumn { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }

    public long? Changeusernum { get; set; }

    public long? Changeinitiator { get; set; }
}
