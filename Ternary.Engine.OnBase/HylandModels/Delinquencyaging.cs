using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Delinquencyaging
{
    public long Dfcytype { get; set; }

    public long Itemtypenum { get; set; }

    public long Delinqlevel { get; set; }

    public long? Agingbasis { get; set; }

    public long? Agingrate { get; set; }

    public long? Facilitynum { get; set; }
}
