using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcapturecheck
{
    public long Rcmcapchecknum { get; set; }

    public long? Payoritemnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Itemnum { get; set; }

    public decimal? Checkamount { get; set; }

    public DateTime? Checkdate { get; set; }

    public string? Checknumber { get; set; }

    public string? Accountnumber { get; set; }

    public string? Eobroutingnumber { get; set; }

    public long? Checkpagenum { get; set; }

    public long? Checkpagecount { get; set; }

    public long? Originalitemnum { get; set; }

    public long? Originalpagenum { get; set; }
}
