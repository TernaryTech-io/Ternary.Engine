using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwgl
{
    public long Rcmtwglnum { get; set; }

    public long? Rcmgltypenum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmtwhostnum { get; set; }

    public long? Rcmtwbanknum { get; set; }

    public decimal? Batchamount { get; set; }

    public DateTime? Processeddate { get; set; }

    public DateTime? Lockboxdate { get; set; }

    public string? Twglcomment { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Createdusernum { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public DateTime? Exportdate { get; set; }

    public long? Exportflag { get; set; }

    public DateTime? Posteddate { get; set; }

    public long? Postedflag { get; set; }
}
