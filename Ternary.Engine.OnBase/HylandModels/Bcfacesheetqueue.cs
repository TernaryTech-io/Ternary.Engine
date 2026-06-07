using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bcfacesheetqueue
{
    public long? Itemnum { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Status { get; set; }

    public DateTime? Entrydate { get; set; }

    public DateTime? Printeddate { get; set; }

    public long? Flags { get; set; }

    public long? Stmtformatnum { get; set; }
}
