using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufcustomaction
{
    public long Ufcustomactionnum { get; set; }

    public long? Ufformnum { get; set; }

    public long? Formrevnum { get; set; }

    public string? Ufcustomactionname { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public string? Ufcustomactiondesc { get; set; }
}
