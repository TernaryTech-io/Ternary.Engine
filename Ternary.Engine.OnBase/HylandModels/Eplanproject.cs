using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanproject
{
    public long Epprojectnum { get; set; }

    public long? Flags { get; set; }

    public string? Epprojname { get; set; }

    public string? Epprojextid { get; set; }

    public DateTime? Epprojdate { get; set; }

    public string? Epprojidentifier { get; set; }

    public long? Epreviewtypenum { get; set; }

    public string? Epstatus { get; set; }

    public long? Epsiteaddressnum { get; set; }

    public long? Status { get; set; }

    public long? Epprojectgroupnum { get; set; }

    public long? Formitemnum { get; set; }
}
