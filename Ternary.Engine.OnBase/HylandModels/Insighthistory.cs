using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Insighthistory
{
    public long Itemnum { get; set; }

    public long? Actionnum { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Laststatuschangedate { get; set; }

    public long Itemtypenum { get; set; }

    public long? Status { get; set; }

    public long Filetypenum { get; set; }

    public long? Docrevnum { get; set; }
}
