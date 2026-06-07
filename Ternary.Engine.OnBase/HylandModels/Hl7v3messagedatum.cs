using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3messagedatum
{
    public long Hl7v3msgdatanum { get; set; }

    public long? Seqnum { get; set; }

    public long? Hl7v3objectid { get; set; }

    public string? Hl7v3objecttype { get; set; }

    public string? Hl7v3data { get; set; }
}
