using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amvotemember
{
    public long Amvotemembernum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Ammembernum { get; set; }

    public long? Connectedstate { get; set; }

    public long? Activitystate { get; set; }

    public DateTime? Connecttime { get; set; }

    public long? Flags { get; set; }
}
