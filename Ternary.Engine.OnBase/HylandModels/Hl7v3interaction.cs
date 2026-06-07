using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3interaction
{
    public long Hl7v3interactnum { get; set; }

    public string? Hl7v3name { get; set; }

    public string? Hl7v3customname { get; set; }

    public string? Hl7v3interactionid { get; set; }

    public string? Hl7v3xsdlocation { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
