using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedlogevent
{
    public long Schedlogeventnum { get; set; }

    public long? Wkstninstnum { get; set; }

    public long? Procinstnum { get; set; }

    public long? Logtype { get; set; }

    public long? Flags { get; set; }

    public long? Detaillevel { get; set; }

    public DateTime? Eventtime { get; set; }

    public string? Eventsourcename { get; set; }

    public string? Messagetext { get; set; }

    public long? Param1 { get; set; }

    public long? Param2 { get; set; }

    public long? Param3 { get; set; }
}
