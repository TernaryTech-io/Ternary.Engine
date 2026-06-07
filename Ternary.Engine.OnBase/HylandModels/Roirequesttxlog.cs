using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirequesttxlog
{
    public long Roireqtxlognum { get; set; }

    public long? Roirequestnum { get; set; }

    public long? Priorstatus { get; set; }

    public long? Newstatus { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Usernum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }
}
