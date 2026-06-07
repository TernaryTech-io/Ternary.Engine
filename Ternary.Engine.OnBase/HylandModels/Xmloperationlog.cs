using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xmloperationlog
{
    public long Xmloplognum { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Queuedcount { get; set; }

    public long? Portfmtnum { get; set; }

    public long? Xmlformatnum { get; set; }

    public long? Keysettablenum { get; set; }

    public long? Errornum { get; set; }

    public string? Errormsg { get; set; }

    public long? Xmllognum { get; set; }
}
