using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsbatch
{
    public long Batchnum { get; set; }

    public long? Lockboxnum { get; set; }

    public long? Imsdocgroupid { get; set; }

    public long? Imsworktype { get; set; }

    public long? Imsbatchid { get; set; }

    public long? Imsbatchnum { get; set; }

    public long? Imsblocknum { get; set; }

    public string? Imsprocesstype { get; set; }

    public DateTime? Batchdate { get; set; }

    public DateTime? Systemdate { get; set; }

    public DateTime? Depositdate { get; set; }

    public DateTime? Processdate { get; set; }

    public DateTime? Receiveddate { get; set; }

    public DateTime? Consolidationdate { get; set; }

    public long? Consolidationnum { get; set; }

    public long? Consolidationid { get; set; }

    public long? Checkcount { get; set; }

    public decimal? Checktotal { get; set; }

    public long? Stubcount { get; set; }

    public decimal? Stubtotal { get; set; }

    public long? Itemcount { get; set; }

    public string? P1operatorid { get; set; }

    public long? P1stationid { get; set; }

    public string? P2operatorid { get; set; }

    public long? P2stationid { get; set; }

    public long? Hostfileid { get; set; }

    public long? Workflowid { get; set; }
}
