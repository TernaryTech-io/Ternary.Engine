using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dashboardxuser
{
    public long Dashboardnum { get; set; }

    public long Usernum { get; set; }

    public long Usertype { get; set; }

    public long? Roletype { get; set; }

    public long? Flags { get; set; }
}
