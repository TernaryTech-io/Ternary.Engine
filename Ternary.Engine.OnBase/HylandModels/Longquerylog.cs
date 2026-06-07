using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Longquerylog
{
    public long Longquerynum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public long? Secondsduration { get; set; }

    public DateTime? Querytime { get; set; }

    public string? Fromclause { get; set; }

    public string? Sqlstatement { get; set; }
}
