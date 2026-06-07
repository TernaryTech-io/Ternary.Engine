using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eisofframp
{
    public long Eisofframpnum { get; set; }

    public long? Offramptype { get; set; }

    public long? Eisextrnalauthnum { get; set; }

    public string? Offrampname { get; set; }

    public string? Offrampcfgblob { get; set; }

    public long? Offrampcontractblobnum { get; set; }

    public string? Description { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }
}
