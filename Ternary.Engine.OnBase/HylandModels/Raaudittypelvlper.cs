using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raaudittypelvlper
{
    public long? Raaudittypenum { get; set; }

    public long? Ralevel { get; set; }

    public long? Daystorespond { get; set; }

    public long? Daysfordecision { get; set; }

    public long? Daystostoprecoup { get; set; }

    public DateTime? Effectivestartdate { get; set; }

    public DateTime? Effectiveenddate { get; set; }

    public long? Flags { get; set; }
}
