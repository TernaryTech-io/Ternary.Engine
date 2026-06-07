using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapbicprqueue
{
    public long Saptransactionnum { get; set; }

    public long? Bicqueuenum { get; set; }

    public string? Filename { get; set; }

    public long? Dataformat { get; set; }

    public string? Sapobjectid { get; set; }

    public DateTime? Transactiondate { get; set; }

    public long? Notified { get; set; }

    public string? Bicfilename { get; set; }
}
