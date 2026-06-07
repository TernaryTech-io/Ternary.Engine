using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3actionprocessor
{
    public long Hl7v3actionpronum { get; set; }

    public string? Hl7v3actionname { get; set; }

    public string? Hl7v3classname { get; set; }

    public long? Isactive { get; set; }

    public long? Flags { get; set; }

    public string? Hl7v3actiontype { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
