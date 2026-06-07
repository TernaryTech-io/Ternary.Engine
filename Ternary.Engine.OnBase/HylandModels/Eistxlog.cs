using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eistxlog
{
    public long Eistxlognum { get; set; }

    public long? Usernum { get; set; }

    public long? Modulenum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Severityflag { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Txlogtext { get; set; }
}
