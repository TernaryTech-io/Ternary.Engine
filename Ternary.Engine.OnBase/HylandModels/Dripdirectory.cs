using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dripdirectory
{
    public long Dripprocessnum { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Parentprocessnum { get; set; }

    public string? Procfoldername { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Dripseparator { get; set; }

    public long? Flags { get; set; }
}
