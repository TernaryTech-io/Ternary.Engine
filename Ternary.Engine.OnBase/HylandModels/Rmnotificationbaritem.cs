using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmnotificationbaritem
{
    public long Nbiid { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Fromusernum { get; set; }

    public long? Tousernum { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectkey { get; set; }

    public long? Objectsubkey { get; set; }

    public string? Rmdescription { get; set; }

    public long? Applicationid { get; set; }
}
