using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanresolvedcomment
{
    public long? Eplancommentnum { get; set; }

    public string? Eptext { get; set; }

    public DateTime? Eptextdate { get; set; }

    public long? Docrevnum { get; set; }

    public long? Pagenum { get; set; }
}
