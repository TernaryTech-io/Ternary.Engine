using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcruntimelogdetail
{
    public long Dcruntimelgdtlnum { get; set; }

    public long? Dcruntimelognum { get; set; }

    public long? Sequencenum { get; set; }

    public long? Dcruntimeobjectnum { get; set; }

    public long? Dcruntimeobjecttype { get; set; }

    public string? Detailmessage { get; set; }

    public long? Flags { get; set; }
}
