using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanprojstate
{
    public long Epprojstatenum { get; set; }

    public long? Epprojectnum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Eplogactionnum { get; set; }
}
