using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmreminder
{
    public long Fcremindernum { get; set; }

    public long? Entitytypenum { get; set; }

    public long? Etitemid { get; set; }

    public long? Stagenum { get; set; }

    public string? Fcremindertime { get; set; }

    public long? Fcremindertype { get; set; }
}
