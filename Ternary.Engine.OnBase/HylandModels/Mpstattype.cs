using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpstattype
{
    public long Mpstattypenum { get; set; }

    public long? Stattype { get; set; }

    public long? Frequency { get; set; }

    public long? Isactive { get; set; }

    public long? Flags { get; set; }

    public string? Mpstattypename { get; set; }
}
