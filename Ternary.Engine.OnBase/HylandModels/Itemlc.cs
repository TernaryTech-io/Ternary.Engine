using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemlc
{
    public long Lcnum { get; set; }

    public long Itemnum { get; set; }

    public long? Foldernum { get; set; }

    public long Statenum { get; set; }

    public DateTime? Transdate { get; set; }

    public long? Transitnum { get; set; }

    public long? Usernum { get; set; }

    public long? Assignedtogroup { get; set; }

    public long? Assignedtouser { get; set; }

    public long? Status { get; set; }
}
