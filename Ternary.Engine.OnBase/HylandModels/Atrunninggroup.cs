using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Atrunninggroup
{
    public long Atgroupexecnum { get; set; }

    public long? Atprogramexecnum { get; set; }

    public long? Atprogramnum { get; set; }

    public long? Atstepgroupnum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Datecompleted { get; set; }

    public long? Status { get; set; }

    public long? Priority { get; set; }
}
