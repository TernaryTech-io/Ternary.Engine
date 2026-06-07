using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eccompletionaction
{
    public long Ecactionnum { get; set; }

    public string? Ecactionname { get; set; }

    public long? Ecstorenum { get; set; }

    public long? Ecactiontype { get; set; }

    public long? Ecactionlcnum { get; set; }

    public long? Eformpjobdtnum { get; set; }

    public long? Initiatejob { get; set; }

    public long? Usersettable { get; set; }

    public decimal? Priceperitem { get; set; }

    public decimal? Priceperpage { get; set; }

    public decimal? Basecost { get; set; }

    public decimal? Minimumcost { get; set; }
}
