using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amsectiontext
{
    public long Sectiontextnum { get; set; }

    public long? Agendasectionnum { get; set; }

    public long? Texttypenum { get; set; }

    public long? Seqnum { get; set; }

    public string? Sectiontext { get; set; }

    public long? Flags { get; set; }
}
