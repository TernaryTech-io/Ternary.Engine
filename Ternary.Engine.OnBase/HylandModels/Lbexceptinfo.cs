using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbexceptinfo
{
    public long Exceptinfonum { get; set; }

    public long? Batchnum { get; set; }

    public long? Transactionnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Exceptionflag { get; set; }

    public DateTime? Isprocessingdate { get; set; }

    public long? Exceptionstatus { get; set; }

    public long? Decisionstate { get; set; }

    public long? Dirtykey { get; set; }

    public string? Isfilename { get; set; }

    public long? Seqnum { get; set; }

    public long? Exceptfieldnum { get; set; }

    public string? Externaluserid { get; set; }
}
