using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userdashboardlayout
{
    public long Dashboardnum { get; set; }

    public long Usernum { get; set; }

    public long? Obblobnum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public long? Fullscreenblobnum { get; set; }
}
