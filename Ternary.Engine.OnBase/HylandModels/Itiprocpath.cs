using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itiprocpath
{
    public long Institution { get; set; }

    public string? Allitemspath { get; set; }

    public string? Statuspath { get; set; }

    public string? Reinstatepath { get; set; }

    public string? Checkmatchpath { get; set; }

    public long? Creditsfirst { get; set; }

    public DateTime? Reinstatedate { get; set; }

    public DateTime? Repassdate { get; set; }

    public DateTime? Dailyitemsdate { get; set; }

    public DateTime? Deletedate { get; set; }
}
