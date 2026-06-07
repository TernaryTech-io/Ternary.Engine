using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dbupgradexdbseclog
{
    public long? Dbupgradenum { get; set; }

    public long? Dbsectionnum { get; set; }

    public string? Fromdbversion { get; set; }

    public string? Todbversion { get; set; }
}
