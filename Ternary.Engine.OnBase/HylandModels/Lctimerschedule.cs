using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lctimerschedule
{
    public long Timernum { get; set; }

    public long Executionday { get; set; }

    public long? Executionstart { get; set; }

    public long? Executionend { get; set; }

    public long? Flags { get; set; }
}
