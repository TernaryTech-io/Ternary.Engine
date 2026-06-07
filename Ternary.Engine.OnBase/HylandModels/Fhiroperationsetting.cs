using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhiroperationsetting
{
    public long Fhiropsettingnum { get; set; }

    public long? Fhiroperationnum { get; set; }

    public string? Fhiropsettingname { get; set; }

    public string? Fhiropsettingvalue { get; set; }

    public long? Fhiropsettingtype { get; set; }

    public long? Flags { get; set; }
}
