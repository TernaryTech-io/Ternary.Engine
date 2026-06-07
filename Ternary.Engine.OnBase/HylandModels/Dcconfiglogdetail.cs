using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcconfiglogdetail
{
    public long Dcconfiglogdtlnum { get; set; }

    public long? Dcconfiglognum { get; set; }

    public long? Sequencenum { get; set; }

    public long? Dcconfigobjectnum { get; set; }

    public long? Dcconfigobjecttype { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }

    public string? Detailmessage { get; set; }

    public long? Flags { get; set; }
}
