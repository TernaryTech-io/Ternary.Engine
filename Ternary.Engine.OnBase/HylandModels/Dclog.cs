using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dclog
{
    public long Dclognum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Actionnum { get; set; }

    public string? Messagetext { get; set; }

    public long? Dctemplatenum { get; set; }

    public long? Storeditemnum { get; set; }

    public string? Workerid { get; set; }

    public long? Totaltime { get; set; }

    public long? Tracelvl { get; set; }

    public long? Severityflag { get; set; }

    public long? Logsource { get; set; }

    public DateTime? Requesttime { get; set; }

    public DateTime? Contextstart { get; set; }

    public DateTime? Contextstop { get; set; }

    public DateTime? Expansionstart { get; set; }
}
