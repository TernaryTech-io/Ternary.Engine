using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Exportmanager
{
    public long Exportmgrnum { get; set; }

    public string? Exportmgrname { get; set; }

    public string? Autonamestring { get; set; }

    public long? Formatnum { get; set; }

    public long? Defaultdate { get; set; }

    public long? Envelopenum { get; set; }

    public long? Exportmgrflags { get; set; }

    public long? Numbercopies { get; set; }
}
