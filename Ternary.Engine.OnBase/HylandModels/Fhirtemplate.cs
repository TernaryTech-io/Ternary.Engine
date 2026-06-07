using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirtemplate
{
    public long Fhirtemplatenum { get; set; }

    public string? Fhirtemplatename { get; set; }

    public long? Fhirrestypenum { get; set; }

    public long? Flags { get; set; }
}
