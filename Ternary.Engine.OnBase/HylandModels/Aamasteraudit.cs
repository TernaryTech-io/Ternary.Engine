using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aamasteraudit
{
    public long Masterauditnum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Logoperationid { get; set; }

    public long? Usernum { get; set; }

    public long? Audittablenum { get; set; }

    public long? Flags { get; set; }
}
