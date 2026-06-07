using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirejectreason
{
    public long Rejectreasonnum { get; set; }

    public string? Rejectreason { get; set; }

    public long? Formatnum { get; set; }

    public string? Rejectreasonname { get; set; }

    public long? Facilitynum { get; set; }
}
