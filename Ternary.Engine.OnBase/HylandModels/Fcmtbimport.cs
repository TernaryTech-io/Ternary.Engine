using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmtbimport
{
    public long Fctbimportnum { get; set; }

    public string? Fctitle { get; set; }

    public DateTime? Fcimportdate { get; set; }

    public long? Fcaccttypenum { get; set; }

    public long? Fccloseeventnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Flags { get; set; }
}
