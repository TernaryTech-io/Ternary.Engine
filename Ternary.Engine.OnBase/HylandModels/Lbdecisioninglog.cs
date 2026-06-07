using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbdecisioninglog
{
    public long Decisionlognum { get; set; }

    public DateTime? Logdate { get; set; }

    public DateTime? Depositdate { get; set; }

    public long? Exceptinfonum { get; set; }

    public string? Externaluserid { get; set; }

    public long? Actionnum { get; set; }

    public long? Lockboxnum { get; set; }

    public string? Alphaisbatchnum { get; set; }

    public long? Transactionnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Lbvalue1 { get; set; }

    public string? Lbvalue2 { get; set; }
}
