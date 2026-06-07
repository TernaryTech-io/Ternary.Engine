using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3template
{
    public long Hl7v3templatenum { get; set; }

    public string? Hl7v3name { get; set; }

    public long? Hl7v3interactnum { get; set; }

    public string? Hl7v3sendingfacfilter { get; set; }

    public string? Hl7v3sendingappfilter { get; set; }

    public string? Hl7v3channeltypefilter { get; set; }

    public long? Isactive { get; set; }

    public string? Hl7v3templatetype { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
