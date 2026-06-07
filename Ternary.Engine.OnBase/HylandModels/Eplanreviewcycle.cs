using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanreviewcycle
{
    public long Epreviewcyclenum { get; set; }

    public long? Epprojectnum { get; set; }

    public DateTime? Epdatestart { get; set; }

    public DateTime? Epdateend { get; set; }

    public long? Status { get; set; }

    public DateTime? Epduedate { get; set; }

    public DateTime? Epreviewerduedate { get; set; }
}
