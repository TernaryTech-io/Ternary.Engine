using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsregistration
{
    public long Tpsregnum { get; set; }

    public string? Tpsuniqueid { get; set; }

    public DateTime? Lastpingtime { get; set; }

    public long? Active { get; set; }

    public long? Resetcache { get; set; }

    public long? Configchanged { get; set; }

    public long? Regtype { get; set; }

    public string? Certidentifier { get; set; }
}
