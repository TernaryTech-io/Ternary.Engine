using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eisgwoperation
{
    public long Eisgwoperationnum { get; set; }

    public string? Weboperationname { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectid { get; set; }

    public long? Operationtypenum { get; set; }

    public long? Eisgwversion { get; set; }

    public string? Canonicalname { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public long? Subobjectid { get; set; }

    public long? Responseoperationnum { get; set; }
}
