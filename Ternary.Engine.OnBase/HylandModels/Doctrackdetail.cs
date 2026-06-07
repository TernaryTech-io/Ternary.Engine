using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctrackdetail
{
    public long? Foldernum { get; set; }

    public DateTime? Lastinteractiondate { get; set; }

    public DateTime? Followupdate { get; set; }

    public long? Usernum { get; set; }

    public long? Compliancestatus { get; set; }

    public long? Active { get; set; }

    public long? Flags { get; set; }

    public DateTime? Fiscalyearstart { get; set; }

    public long? Institution { get; set; }
}
