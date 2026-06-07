using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Analysishist
{
    public long Analysishistnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Comparecopy { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public long? Analysischecksumtype { get; set; }

    public DateTime? Analyzedon { get; set; }

    public long? Analysisresult { get; set; }

    public long? Performedrepairs { get; set; }

    public long? Sourcetype { get; set; }

    public long? Sourcenum { get; set; }

    public long? Elapsedseconds { get; set; }

    public long? Filesonvolume { get; set; }

    public long? Filesanalyzed { get; set; }

    public long? Reportnum { get; set; }
}
