using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Datamining
{
    public long Itemtypenum { get; set; }

    public long? Indexmodelfile { get; set; }

    public long? Reportmodelfile { get; set; }

    public string? Launchfile { get; set; }

    public string? Monarchexpfile { get; set; }

    public long? Monarchexptype { get; set; }

    public long Itrevnum { get; set; }

    public long? Maxitrevnum { get; set; }
}
