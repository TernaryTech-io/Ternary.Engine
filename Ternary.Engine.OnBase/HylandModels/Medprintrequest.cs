using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medprintrequest
{
    public long? Usernum { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Printdatatype { get; set; }

    public long? Printtype { get; set; }

    public long? Printflags { get; set; }

    public long? Pagenum { get; set; }

    public long? Printformatnum { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Chtnum { get; set; }

    public long? Itemnum { get; set; }

    public string? Delivinstructions { get; set; }
}
