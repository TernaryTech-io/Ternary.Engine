using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanlog
{
    public long Eplognum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Usernum { get; set; }

    public long? Logaction { get; set; }

    public string? Portaluser { get; set; }

    public long? Success { get; set; }

    public long? Objectnum { get; set; }

    public long? Objecttype { get; set; }

    public string? Serverip { get; set; }

    public string? Sourceip { get; set; }

    public string? Epmessagetext { get; set; }
}
