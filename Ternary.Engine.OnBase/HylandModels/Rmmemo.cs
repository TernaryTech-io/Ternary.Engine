using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmemo
{
    public long Memoid { get; set; }

    public string? Memo { get; set; }

    public long? Sourceattrid { get; set; }
}
