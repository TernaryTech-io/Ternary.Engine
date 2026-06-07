using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Batchfile
{
    public long Batchfilenum { get; set; }

    public string? Batchfilename { get; set; }

    public long? Flags { get; set; }
}
