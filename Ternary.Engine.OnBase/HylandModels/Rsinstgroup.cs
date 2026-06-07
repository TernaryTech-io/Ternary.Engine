using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsinstgroup
{
    public long Rsgroupnum { get; set; }

    public string? Beginstnumui { get; set; }

    public string? Endinstnumui { get; set; }

    public long? Numinstruments { get; set; }

    public long? Usernum { get; set; }

    public long? Status { get; set; }

    public DateTime? Reserveddate { get; set; }

    public DateTime? Datemodified { get; set; }
}
