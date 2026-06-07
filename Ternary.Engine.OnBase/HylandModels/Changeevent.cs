using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Changeevent
{
    public long Changeeventnum { get; set; }

    public DateTime? Datechanged { get; set; }

    public long? Usernum { get; set; }

    public long? Eventsource { get; set; }

    public string? Description { get; set; }
}
