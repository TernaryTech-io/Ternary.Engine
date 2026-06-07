using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptschedulerxcol
{
    public long Schedtasknum { get; set; }

    public long? Rptprovidernum { get; set; }

    public string? Rptcolumnid { get; set; }

    public string? Columnalias { get; set; }

    public long? Columnmode { get; set; }

    public long? Sequence { get; set; }

    public long? Width { get; set; }

    public long? Flags { get; set; }
}
