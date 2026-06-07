using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aitrainingquery
{
    public long Aitrainquerynum { get; set; }

    public long? Itemtypenum { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Jobitemtypenums { get; set; }
}
