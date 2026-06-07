using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgajob
{
    public long S3dgajobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public DateTime? Startcriteria { get; set; }

    public DateTime? Endcriteria { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public long? Processingstatus { get; set; }

    public DateTime? Jobstarted { get; set; }

    public DateTime? Lastactivity { get; set; }

    public long? Completionstatus { get; set; }

    public string? Lasterror { get; set; }
}
