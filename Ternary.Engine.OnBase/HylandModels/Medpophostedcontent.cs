using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medpophostedcontent
{
    public long Hostedcontentnum { get; set; }

    public string? Description { get; set; }

    public long? Enabled { get; set; }

    public long? Seqnum { get; set; }

    public string? Tooltip { get; set; }

    public long? Iconnum { get; set; }

    public long? Flags { get; set; }

    public string? Meddocpopurl { get; set; }
}
