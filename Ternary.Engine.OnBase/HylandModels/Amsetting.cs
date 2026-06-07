using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amsetting
{
    public string? Amdateformat { get; set; }

    public string? Amtimeformat { get; set; }

    public long? Amagendaflags { get; set; }

    public long? Amminutesflags { get; set; }

    public long? Flags { get; set; }

    public string? Intvotingserverurl { get; set; }

    public string? Extvotingserverurl { get; set; }
}
