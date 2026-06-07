using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Exceptreport
{
    public long Reportnum { get; set; }

    public string? Reportname { get; set; }

    public long? Baseitemtypenum { get; set; }

    public long? Relitemtypenum { get; set; }

    public long? Reportflags { get; set; }

    public long? Codekeytypenum { get; set; }

    public long? Statuskeytypenum { get; set; }

    public long? Maxindentlevel { get; set; }

    public long? Printkeytypenum { get; set; }

    public long? Envelopenum { get; set; }

    public long? Lcnum { get; set; }
}
