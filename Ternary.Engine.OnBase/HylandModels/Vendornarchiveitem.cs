using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vendornarchiveitem
{
    public long? Itemnum { get; set; }

    public long? Vendornarchivenum { get; set; }

    public string? Studyinstanceuid { get; set; }

    public string? Studyseriesuid { get; set; }

    public string? Accessionnum { get; set; }

    public long? Flags { get; set; }
}
