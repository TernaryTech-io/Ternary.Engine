using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wquery
{
    public long Mwquerynum { get; set; }

    public string? Queryname { get; set; }

    public long? Querytypenum { get; set; }

    public string? Querytext { get; set; }

    public long? Mwconnectionnum { get; set; }

    public string? Querydesc { get; set; }

    public long? Flags { get; set; }
}
