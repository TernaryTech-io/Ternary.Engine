using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lctimer
{
    public long Timernum { get; set; }

    public string? Timername { get; set; }

    public long? Flags { get; set; }

    public long? Days { get; set; }

    public long? Hours { get; set; }

    public long? Minutes { get; set; }

    public long? Actionnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Scope { get; set; }

    public DateTime? Lastexecuted { get; set; }

    public long? Defaultcalendar { get; set; }

    public long? Configversion { get; set; }
}
