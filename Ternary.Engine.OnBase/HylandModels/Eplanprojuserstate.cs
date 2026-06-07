using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanprojuserstate
{
    public long Epprojustatenum { get; set; }

    public long? Epprojstatenum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Eplogactionnum { get; set; }
}
