using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpstat
{
    public long? Mppublishernum { get; set; }

    public long? Mpmedianum { get; set; }

    public long? Mpstattypenum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Mpstatvalue { get; set; }

    public long? Mpstatvaluehigh { get; set; }
}
