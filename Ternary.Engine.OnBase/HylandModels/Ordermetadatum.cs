using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ordermetadatum
{
    public long Fieldnum { get; set; }

    public string? Displayname { get; set; }

    public string? Hl7valuereference { get; set; }

    public long? Keytypenum { get; set; }

    public long? Flags { get; set; }
}
