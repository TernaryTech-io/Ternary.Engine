using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3appconfig
{
    public long Hl7v3appconfignum { get; set; }

    public string? Hl7v3name { get; set; }

    public string? Hl7v3value { get; set; }

    public long? Flags { get; set; }

    public string? Hl7v3apptype { get; set; }

    public string? Hl7v3configtype { get; set; }
}
