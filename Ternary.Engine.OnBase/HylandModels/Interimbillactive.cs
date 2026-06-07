using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Interimbillactive
{
    public long Chtnum { get; set; }

    public long? Admittypenum { get; set; }

    public long? Facilitynum { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Lastprocessed { get; set; }

    public long? Isactive { get; set; }
}
