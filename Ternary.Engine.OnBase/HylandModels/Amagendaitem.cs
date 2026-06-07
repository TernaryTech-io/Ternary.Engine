using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendaitem
{
    public long Agendaitemnum { get; set; }

    public long? Agendaitemtypenum { get; set; }

    public long? Ammeetingtypenum { get; set; }

    public string? Agendatitle { get; set; }

    public long? Status { get; set; }

    public long? Submitter { get; set; }

    public long? Closedsession { get; set; }

    public long? Eformnum { get; set; }

    public long? Flags { get; set; }

    public long? Aiparentnum { get; set; }

    public long? Tgttmeetingnum { get; set; }

    public string? Amminutes { get; set; }

    public string? Amnumber { get; set; }

    public DateTime? Ameventtime { get; set; }

    public long? Issection { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Mpeventpointnum { get; set; }

    public long? Sourceagendaitemnum { get; set; }

    public long? Ufformitemnum { get; set; }
}
