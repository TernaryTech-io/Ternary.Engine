using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lifespanbatch
{
    public long? Batchnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public DateTime? Checkdate { get; set; }

    public DateTime? Datestored { get; set; }
}
