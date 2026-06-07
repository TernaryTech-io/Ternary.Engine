using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raappealletter
{
    public long Raappealletternum { get; set; }

    public long? Racclaimnum { get; set; }

    public long? Ralevel { get; set; }

    public DateTime? Lettergendate { get; set; }

    public DateTime? Lettersentdate { get; set; }

    public DateTime? Entereddate { get; set; }

    public long? Generatedbyusernum { get; set; }

    public long? Itemnum { get; set; }

    public string? Appealcomment { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Shippedbyuserid { get; set; }

    public long? Seqnum { get; set; }
}
