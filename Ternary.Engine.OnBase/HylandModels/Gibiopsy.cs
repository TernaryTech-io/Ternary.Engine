using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gibiopsy
{
    public long Gibiopsynum { get; set; }

    public long? Gipathologynum { get; set; }

    public long? Gifindtypenum { get; set; }

    public long? Gifindingnum { get; set; }

    public string? Specimendesc { get; set; }

    public string? Clinicalhistory { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Giquantity { get; set; }

    public string? Gibiopsypriority { get; set; }
}
