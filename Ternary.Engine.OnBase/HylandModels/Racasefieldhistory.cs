using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Racasefieldhistory
{
    public long Racasefieldhisnum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Messagetext { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Severityflag { get; set; }

    public long? Racclaimnum { get; set; }

    public string? Rafieldchanged { get; set; }

    public string? Rapreviousvalue { get; set; }

    public string? Ranewvalue { get; set; }

    public long? Tracelevel { get; set; }
}
