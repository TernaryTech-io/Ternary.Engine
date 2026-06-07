using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Omrrule
{
    public long Omrrulenum { get; set; }

    public long? Omrmarknum { get; set; }

    public long? Flags { get; set; }

    public long? Ruletype { get; set; }

    public long? Leftoperand { get; set; }

    public long? Rightoperand { get; set; }

    public long? Omrresultvalue { get; set; }
}
