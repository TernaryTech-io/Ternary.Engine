using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Radenialletter
{
    public long Radenialletternum { get; set; }

    public long? Rarejectreasonnum { get; set; }

    public long? Ralevel { get; set; }

    public DateTime? Dateappearsonletter { get; set; }

    public DateTime? Datereceived { get; set; }

    public DateTime? Dateenteredonbase { get; set; }

    public long? Letterenteredbyuser { get; set; }

    public long? Itemnum { get; set; }

    public string? Racomment { get; set; }

    public long? Racclaimnum { get; set; }

    public string? Radenialletterid { get; set; }

    public DateTime? Radatecompleted { get; set; }

    public long? Raservicetype { get; set; }

    public long? Rafacilitytype { get; set; }

    public long? Seqnum { get; set; }
}
