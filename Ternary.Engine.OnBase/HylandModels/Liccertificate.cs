using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Liccertificate
{
    public long Liccertificatenum { get; set; }

    public string? Liccertificate1 { get; set; }

    public long? Flags { get; set; }

    public string? Dbvalid { get; set; }

    public DateTime? Installdate { get; set; }

    public long? Licensetype { get; set; }
}
