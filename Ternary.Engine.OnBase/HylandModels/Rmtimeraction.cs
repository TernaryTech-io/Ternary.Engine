using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmtimeraction
{
    public long Timeractionid { get; set; }

    public long? Actionflags { get; set; }

    public long? Actionid { get; set; }

    public string? Actionparams { get; set; }

    public long? Actiontype { get; set; }

    public long? Timernum { get; set; }
}
