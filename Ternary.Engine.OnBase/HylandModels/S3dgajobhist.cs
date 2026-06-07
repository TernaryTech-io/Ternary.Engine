using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgajobhist
{
    public long S3dgajobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public DateTime? Startcriteria { get; set; }

    public DateTime? Endcriteria { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public DateTime? Jobstarted { get; set; }

    public DateTime? Jobended { get; set; }

    public long? Completionstatus { get; set; }

    public long? Filesprocessed { get; set; }

    public long? Badfilesfound { get; set; }

    public long? Kbytesdownloaded { get; set; }

    public long? Missingchecksums { get; set; }
}
