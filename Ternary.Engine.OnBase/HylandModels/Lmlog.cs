using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lmlog
{
    public long Lmlognum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Lmevrecordernum { get; set; }

    public long? Licensetype { get; set; }

    public long? Objecttype { get; set; }

    public long? Transactionkey { get; set; }

    public long? Usagecount { get; set; }

    public long? Processflag { get; set; }

    public long? Objectkey { get; set; }

    public string? Lmtxhash { get; set; }

    public long? Cryptotype { get; set; }
}
