using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bcbatch
{
    public long? Batchnum { get; set; }

    public long? Batchid { get; set; }

    public long? Branchid { get; set; }

    public long? Tellerid { get; set; }

    public long? Itemcount { get; set; }

    public long? Telleritemcount { get; set; }

    public long? Onusitemcount { get; set; }

    public long? Transitcount { get; set; }

    public decimal? Onusamount { get; set; }

    public decimal? Transitamount { get; set; }

    public decimal? Amountbalance { get; set; }

    public long? Encodingstate { get; set; }

    public DateTime? Capturedate { get; set; }

    public DateTime? Transmitdate { get; set; }

    public long? Scanoptions { get; set; }

    public string? Parsefilename { get; set; }

    public string? Tellerreportpath { get; set; }

    public long? Balancedusernum { get; set; }

    public DateTime? Balanceddate { get; set; }

    public long? Processflags { get; set; }

    public decimal? Telleramount { get; set; }

    public string? Branchidalphanum { get; set; }

    public string? Telleridalphanum { get; set; }
}
