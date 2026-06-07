using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanprocess
{
    public long Scanprocessnum { get; set; }

    public long? Status { get; set; }

    public long? Indexstatus { get; set; }

    public long? Batchtransition { get; set; }

    public long? Scanprocessflags { get; set; }

    public long? Defaultposition { get; set; }

    public long? Categorystatus { get; set; }
}
