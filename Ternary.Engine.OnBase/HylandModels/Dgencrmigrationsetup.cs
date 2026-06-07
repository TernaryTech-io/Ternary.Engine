using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgencrmigrationsetup
{
    public long? Diskgroupnum { get; set; }

    public long? Firstnewvolume { get; set; }

    public long? Setupstatus { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Olddiskgroupflags { get; set; }

    public long? Newdiskgroupflags { get; set; }

    public long? Usernum { get; set; }

    public long? Volumecompleted { get; set; }
}
