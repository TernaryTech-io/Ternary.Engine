using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanrcuserstate
{
    public long Eprcuserstatenum { get; set; }

    public long? Eprcgroupstatenum { get; set; }

    public DateTime? Ownershipdate { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Eplogactionnum { get; set; }
}
