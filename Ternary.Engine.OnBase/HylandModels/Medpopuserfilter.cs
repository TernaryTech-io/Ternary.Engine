using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medpopuserfilter
{
    public long Obblobnum { get; set; }

    public long? Usernum { get; set; }

    public string? Filtername { get; set; }

    public long? Isdefault { get; set; }

    public long? Ispublic { get; set; }
}
