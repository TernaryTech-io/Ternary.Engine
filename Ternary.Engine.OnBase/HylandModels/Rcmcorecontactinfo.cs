using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcorecontactinfo
{
    public long Rcmcorecntinfonum { get; set; }

    public string? Rcmaddress { get; set; }

    public string? Rcmaddress2 { get; set; }

    public string? Rcmcity { get; set; }

    public string? Rcmstate { get; set; }

    public string? Rcmzip1 { get; set; }

    public string? Rcmhomephone { get; set; }

    public string? Rcmmobilephone { get; set; }

    public string? Rcmworkphone { get; set; }

    public string? Rcmemail { get; set; }

    public string? Rcmtitle { get; set; }

    public string? Rcmzip2 { get; set; }

    public long? Flags { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }
}
