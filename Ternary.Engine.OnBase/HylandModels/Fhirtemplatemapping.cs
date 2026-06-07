using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirtemplatemapping
{
    public long Fhirmappingnum { get; set; }

    public long? Fhirtemplatenum { get; set; }

    public string? Fhirmappingname { get; set; }

    public long? Keytypenum { get; set; }

    public long? Translationtablenum { get; set; }

    public long? Fhirpathnum { get; set; }

    public long? Flags { get; set; }
}
