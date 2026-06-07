using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usergschedulertask
{
    public long Usergroupnum { get; set; }

    public long Schedtasknum { get; set; }

    public long? Flags { get; set; }
}
