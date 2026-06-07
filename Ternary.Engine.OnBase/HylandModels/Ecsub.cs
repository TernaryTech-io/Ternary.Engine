using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecsub
{
    public long Ecsubsnum { get; set; }

    public long? Ecaccountnum { get; set; }

    public long? Ecsubstypenum { get; set; }

    public long? Ecstorenum { get; set; }

    public string? Ecname { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Dltokensavail { get; set; }

    public long? Flags { get; set; }

    public long? Deleteditem { get; set; }
}
