using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rarecordreqletter
{
    public long Racreqletternum { get; set; }

    public long? Racclaimnum { get; set; }

    public string? Rarequestletterid { get; set; }

    public DateTime? Dateappearsonletter { get; set; }

    public DateTime? Datereceived { get; set; }

    public DateTime? Dateenteredonbase { get; set; }

    public long? Letterenteredbyuser { get; set; }

    public long? Itemnum { get; set; }

    public string? Requestcomment { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Shippedbyuserid { get; set; }

    public long? Seqnum { get; set; }
}
