using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctracdoc
{
    public long Doctracdocsnum { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Institution { get; set; }

    public long? Datekeytypenum { get; set; }

    public long? Docrequired { get; set; }

    public long? Dueperiod { get; set; }

    public long? Expirationperiod { get; set; }

    public long? Warningperiod { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Expirationcycle { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Expirationtype { get; set; }
}
