using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sptimer
{
    public long Sptimernum { get; set; }

    public string? Sptimername { get; set; }

    public long? Parenttype { get; set; }

    public long? Parentnum { get; set; }

    public long? Displayorder { get; set; }

    public long? Active { get; set; }

    public long? Obblobnum { get; set; }
}
