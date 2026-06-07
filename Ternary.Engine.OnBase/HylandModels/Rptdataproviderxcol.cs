using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptdataproviderxcol
{
    public long Rptprovidernum { get; set; }

    public long? Columnid { get; set; }

    public string? Columnalias { get; set; }

    public long? Columnmode { get; set; }

    public long? Sequence { get; set; }

    public long? Flags { get; set; }

    public string Rptcolumnid { get; set; } = null!;
}
