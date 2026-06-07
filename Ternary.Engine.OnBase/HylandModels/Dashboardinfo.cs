using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dashboardinfo
{
    public long Dashboardnum { get; set; }

    public string? Dashboardname { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Obblobnum { get; set; }

    public long? Iconnum { get; set; }

    public string? Description { get; set; }

    public long? Refreshrate { get; set; }

    public long? Flags { get; set; }

    public long? Dashboardmode { get; set; }

    public long? Objecttype { get; set; }
}
