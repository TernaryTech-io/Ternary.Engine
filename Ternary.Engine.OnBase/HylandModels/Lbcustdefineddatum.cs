using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbcustdefineddatum
{
    public long Lockboxnum { get; set; }

    public long Fieldid { get; set; }

    public string? Customfieldname { get; set; }

    public long? Keytypenum { get; set; }
}
