using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amaihistory
{
    public long Amaihistorynum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Agendasectionnum { get; set; }

    public long? Agendaitemnum { get; set; }

    public long? Destmeetingnum { get; set; }

    public long? Destagendaitemnum { get; set; }

    public long? Usernum { get; set; }

    public string? Description { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Historytype { get; set; }

    public long? Flags { get; set; }
}
