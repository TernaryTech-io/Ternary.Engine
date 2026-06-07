using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docrethistory
{
    public long? Itemnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public long? Batchnum { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Processtype { get; set; }

    public DateTime? Processdate { get; set; }

    public long? Rettype { get; set; }

    public long? Retdate { get; set; }

    public long? Delafter { get; set; }

    public long? Delkeytypenum { get; set; }

    public DateTime? Dateexpire { get; set; }
}
