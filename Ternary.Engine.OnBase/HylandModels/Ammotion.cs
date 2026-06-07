using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammotion
{
    public long Motionnum { get; set; }

    public long? Motiontypenum { get; set; }

    public long? Agendaitemnum { get; set; }

    public string? Amnotes { get; set; }

    public long? Amvotetype { get; set; }

    public long? Ammovedby { get; set; }

    public long? Amsecondedby { get; set; }

    public long? Amresults { get; set; }

    public long? Flags { get; set; }

    public long? Ammtnrslttypenum { get; set; }

    public long? Amaieventordernum { get; set; }

    public DateTime? Ameventtime { get; set; }

    public long? Ammotionseriesnum { get; set; }
}
