using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplaneventhistory
{
    public long Epeventhistorynum { get; set; }

    public long? Epprojectnum { get; set; }

    public long? Epreviewcyclenum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Eplogactionnum { get; set; }

    public string? Eventdetail { get; set; }
}
