using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raletter
{
    public long Raletternum { get; set; }

    public long? Ralettertype { get; set; }

    public string? Ralettercomment { get; set; }

    public long? Racclaimnum { get; set; }

    public long? Ralevel { get; set; }

    public DateTime? Letterdate { get; set; }

    public DateTime? Sentdate { get; set; }

    public DateTime? Receiveddate { get; set; }

    public DateTime? Entereddate { get; set; }

    public string? Externalletterid { get; set; }

    public long? Shippedbyuser { get; set; }

    public long? Raletterresult { get; set; }

    public long? Seqnum { get; set; }

    public decimal? Estimatedcharges { get; set; }

    public decimal? Actualcharges { get; set; }

    public long? Rarejectreasonnum { get; set; }

    public long? Enteredbyusernum { get; set; }

    public long? Rafacilitytype { get; set; }

    public long? Raservicetype { get; set; }

    public long? Racausereasonnum { get; set; }
}
