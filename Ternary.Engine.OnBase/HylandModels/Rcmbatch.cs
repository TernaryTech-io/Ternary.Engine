using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbatch
{
    public long? Batchnum { get; set; }

    public DateTime? Batchdate { get; set; }

    public long? Status { get; set; }

    public long? Itemnum { get; set; }

    public long? Rcmqueue { get; set; }

    public string? Arbatchno { get; set; }

    public DateTime? Depositdate { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public decimal? Batchamount { get; set; }

    public string? Lockboxcode { get; set; }

    public string? Rcmuserinitials { get; set; }

    public long? Nullamounts { get; set; }

    public decimal? Checkamount { get; set; }

    public long? Eobcount { get; set; }

    public long? Checkcount { get; set; }

    public long Editusernum { get; set; }

    public string? Rcmcomments { get; set; }
}
