using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendaitemtype
{
    public long Agendaitemtypenum { get; set; }

    public string? Agendaitemtypname { get; set; }

    public long? Flags { get; set; }

    public long? Templatenum { get; set; }

    public long? Revisionnum { get; set; }
}
