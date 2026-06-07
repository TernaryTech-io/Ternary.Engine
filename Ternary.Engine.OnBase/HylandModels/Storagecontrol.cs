using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Storagecontrol
{
    public long Storagenum { get; set; }

    public string? Storagename { get; set; }

    public long? Numbercopies { get; set; }

    public long? Currentvolumenum { get; set; }

    public long? Subdirnum { get; set; }

    public long? Numfiles { get; set; }
}
