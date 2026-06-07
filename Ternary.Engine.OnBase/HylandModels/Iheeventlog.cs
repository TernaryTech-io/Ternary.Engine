using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iheeventlog
{
    public long Iheeventlognum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Receivingsystem { get; set; }

    public string? Sendingsystem { get; set; }

    public string? Endpointaddress { get; set; }

    public string? Ihepatientid { get; set; }

    public string? Ihedocuid { get; set; }

    public string? Ihesubmissionsetuid { get; set; }

    public string? Messagetext { get; set; }

    public long? Flags { get; set; }

    public long? Usernum { get; set; }
}
