using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendaitemact
{
    public long Agendaactionnum { get; set; }

    public long? Agendaitemtypenum { get; set; }

    public string? Agendaactionname { get; set; }

    public long? Flags { get; set; }
}
