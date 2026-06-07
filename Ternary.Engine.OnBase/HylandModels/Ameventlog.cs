using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ameventlog
{
    public long Ameventnum { get; set; }

    public long? Entitytypenum { get; set; }

    public long? Etitemid { get; set; }

    public DateTime? Eteventdate { get; set; }

    public long? Eteventtype { get; set; }

    public long? Etsubtype { get; set; }

    public long? Etapptype { get; set; }

    public string? Username { get; set; }

    public string? Etdescription { get; set; }
}
