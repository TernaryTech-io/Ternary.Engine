using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpcaption
{
    public long Mpcaptionnum { get; set; }

    public long? Mpmedianum { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public string? Mpcaption1 { get; set; }
}
