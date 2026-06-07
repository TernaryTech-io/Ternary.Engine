using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tstest
{
    public long Tstestnum { get; set; }

    public long? Tstestcategorynum { get; set; }

    public long? Testtype { get; set; }

    public string? Tstestname { get; set; }

    public long? Tstestauthornum { get; set; }

    public string? Tstesttext { get; set; }

    public DateTime? Tstestcreationdate { get; set; }

    public DateTime? Tsteststartdate { get; set; }

    public DateTime? Tstestenddate { get; set; }

    public long? Randomizequestions { get; set; }

    public long? Donotrandomizelast { get; set; }

    public long? Minimumtopass { get; set; }

    public long? Isactive { get; set; }

    public long? Flags { get; set; }

    public long? Islocked { get; set; }

    public long? Maxretries { get; set; }

    public long? Tscertitemtypenum { get; set; }
}
