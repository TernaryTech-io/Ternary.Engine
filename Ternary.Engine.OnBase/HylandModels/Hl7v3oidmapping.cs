using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3oidmapping
{
    public long Hl7v3oidmapnum { get; set; }

    public string? Hl7v3name { get; set; }

    public string? Hl7v3oidvalue { get; set; }

    public string? Hl7v3interactionid { get; set; }

    public string? Xpath { get; set; }

    public long? Flags { get; set; }

    public long? Isincremental { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
