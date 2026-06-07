using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulerschedule
{
    public long Schedulenum { get; set; }

    public string? Schedulename { get; set; }

    public string? Scheduledesc { get; set; }

    public long? Schedulestatus { get; set; }

    public long? Wcalnum { get; set; }

    public DateTime? Effectivedatestart { get; set; }

    public DateTime? Effectivedateend { get; set; }

    public long? Flags { get; set; }

    public long? Createduser { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Updateduser { get; set; }

    public DateTime? Updateddate { get; set; }
}
