using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendasection
{
    public long Agendasectionnum { get; set; }

    public string? Agendasectionname { get; set; }

    public string? Amminutes { get; set; }

    public long? Agendaoutlinenum { get; set; }

    public long? Flags { get; set; }

    public long? Parentsecnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Amnumber { get; set; }

    public DateTime? Amstarttime { get; set; }

    public long? Amnumbertypenum { get; set; }
}
