using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Publishlog
{
    public DateTime? Pubdate { get; set; }

    public long? Usernum { get; set; }

    public long? Numcdcopies { get; set; }

    public string? Exportdesc { get; set; }

    public long? Totalcds { get; set; }

    public long? Schedordernum { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public long? Jobnum { get; set; }
}
