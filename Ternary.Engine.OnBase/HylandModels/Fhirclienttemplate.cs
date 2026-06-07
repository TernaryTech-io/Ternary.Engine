using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirclienttemplate
{
    public long? Fhirclienttypenum { get; set; }

    public long? Fhirresourcetypenum { get; set; }

    public string? Fhirclientbaseurl { get; set; }

    public string? Fhirresourceendpoint { get; set; }

    public long? Fhirtemplatenum { get; set; }

    public string? Fhirparametername { get; set; }

    public long? Flags { get; set; }

    public long? Keysettablenum { get; set; }

    public long Fhirclienttmplnum { get; set; }
}
