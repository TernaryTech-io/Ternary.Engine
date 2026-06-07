using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartqueuetxlog
{
    public long Chtqueuetxnum { get; set; }

    public long? Chtnum { get; set; }

    public long? Chtqueuetype { get; set; }

    public DateTime? Availabletime { get; set; }

    public DateTime? Entrytime { get; set; }

    public DateTime? Exittime { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }
}
