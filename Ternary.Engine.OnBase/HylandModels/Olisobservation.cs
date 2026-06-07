using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olisobservation
{
    public long Olisobservenum { get; set; }

    public long? Olisordernum { get; set; }

    public long? Olissessionnum { get; set; }

    public string? Obsvaluetype { get; set; }

    public string? Obsidentifier { get; set; }

    public string? Obstext { get; set; }

    public string? Obscodingsys { get; set; }

    public string? Obsvalue { get; set; }

    public long? Obsvaluetypeenum { get; set; }

    public string? Obsunit { get; set; }

    public string? Obsreferencerange { get; set; }

    public string? Obsabnormal { get; set; }

    public string? Obsresultstatus { get; set; }

    public DateTime? Observationtime { get; set; }

    public string? Obsmethodtext { get; set; }
}
