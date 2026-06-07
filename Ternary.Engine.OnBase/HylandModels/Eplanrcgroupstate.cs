using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanrcgroupstate
{
    public long Eprcgroupstatenum { get; set; }

    public long? Epprojectnum { get; set; }

    public long? Epreviewcyclenum { get; set; }

    public DateTime? Assigneddate { get; set; }

    public long? Usernum { get; set; }

    public string? Groupname { get; set; }

    public long? Eplogactionnum { get; set; }
}
