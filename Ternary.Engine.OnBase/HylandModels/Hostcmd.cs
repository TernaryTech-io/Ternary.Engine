using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hostcmd
{
    public long Hostcmdnum { get; set; }

    public long? Pagenum { get; set; }

    public string? Commandname { get; set; }

    public string? Keystosend { get; set; }

    public long? Postwaitpgchg { get; set; }

    public long? Islastpage { get; set; }
}
