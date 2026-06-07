using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Analysisjob
{
    public long Analysisjobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Comparecopy { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public long? Analysischecksumtype { get; set; }

    public DateTime? Timequeued { get; set; }

    public DateTime? Lastattempt { get; set; }

    public long? Lastabortreason { get; set; }

    public long? Disabled { get; set; }

    public long? Sourcetype { get; set; }

    public long? Sourcenum { get; set; }
}
