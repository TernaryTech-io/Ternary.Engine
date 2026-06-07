using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Processclass
{
    public long Processclassnum { get; set; }

    public string? Processclassname { get; set; }

    public long? Institution { get; set; }

    public long? Distprocessnum { get; set; }

    public long? Distributionflags { get; set; }

    public long? Stmtdelivinfonum { get; set; }

    public long? Statementnum { get; set; }

    public long? Stmtformatnum { get; set; }

    public string? Externalclassname { get; set; }

    public string? Sitecode { get; set; }
}
