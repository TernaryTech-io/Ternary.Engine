using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartxitemdatum
{
    public long Chtnum { get; set; }

    public long Itemnum { get; set; }

    public long? Analysisstatus { get; set; }

    public long? Currentpage { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Hl7externaldocid { get; set; }

    public long? Seqnum { get; set; }

    public long? Relateditemnum { get; set; }

    public long? Relatedpagenum { get; set; }

    public long? Codingstatus { get; set; }
}
