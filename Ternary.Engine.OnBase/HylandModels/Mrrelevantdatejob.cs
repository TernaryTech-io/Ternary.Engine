using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrrelevantdatejob
{
    public long Reldatejobnum { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Status { get; set; }

    public long? Lastitemupdated { get; set; }

    public long? Processedcount { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Elapsedtime { get; set; }

    public long? Flags { get; set; }
}
