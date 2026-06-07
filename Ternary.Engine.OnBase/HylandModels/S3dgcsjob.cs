using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgcsjob
{
    public long S3dgcsjobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public DateTime? Startcriteria { get; set; }

    public DateTime? Endcriteria { get; set; }

    public long? Processingstatus { get; set; }

    public DateTime? Jobstarted { get; set; }

    public DateTime? Lastactivity { get; set; }
}
