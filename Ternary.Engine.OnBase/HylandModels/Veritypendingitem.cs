using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Veritypendingitem
{
    public long? Itemnum { get; set; }

    public long? Itemtypenumfrom { get; set; }

    public long? Itemtypenumto { get; set; }

    public long? Filetypenumfrom { get; set; }

    public long? Filetypenumto { get; set; }

    public long? Docrevnumfrom { get; set; }

    public long? Docrevnumto { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Opcode { get; set; }

    public long? Status { get; set; }

    public string? Requestid { get; set; }

    public long Pendingitemnum { get; set; }
}
