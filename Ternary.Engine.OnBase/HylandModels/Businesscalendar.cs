using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Businesscalendar
{
    public long Wcalnum { get; set; }

    public string? Wcalname { get; set; }

    public long? Institution { get; set; }

    public long? Workweekstartday { get; set; }

    public long? Flags { get; set; }
}
