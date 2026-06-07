using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vbscripthist
{
    public long Vbscriptnum { get; set; }

    public long Seqnum { get; set; }

    public string? Vbscript { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Usernum { get; set; }

    public string? Checkoutcomment { get; set; }
}
