using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplantext
{
    public long Eplantextnum { get; set; }

    public string? Eptext { get; set; }

    public DateTime? Eptextdate { get; set; }

    public long? Eptexttype { get; set; }
}
