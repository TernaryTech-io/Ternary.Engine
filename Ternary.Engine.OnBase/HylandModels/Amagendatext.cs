using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendatext
{
    public long Agendatextnum { get; set; }

    public long? Agendaitemnum { get; set; }

    public long? Texttypenum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public string? Agendaitemtext { get; set; }
}
