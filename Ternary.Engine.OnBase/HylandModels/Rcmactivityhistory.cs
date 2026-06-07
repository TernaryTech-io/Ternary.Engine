using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmactivityhistory
{
    public long Rcmacthistorynum { get; set; }

    public long? Rcmwlcommonnum { get; set; }

    public long? Rcmactivitynum { get; set; }

    public DateTime? Rcmactivitydate { get; set; }

    public long? Rcmworklistnum { get; set; }

    public long? Rcmwlreasonnum { get; set; }

    public string? Rcmnote { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Rcmdmdenialnum { get; set; }
}
