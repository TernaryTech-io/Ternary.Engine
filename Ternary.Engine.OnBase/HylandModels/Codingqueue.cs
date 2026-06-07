using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Codingqueue
{
    public long Codingqueuenum { get; set; }

    public string? Codingqueuename { get; set; }

    public long? Queuetype { get; set; }

    public long? Flags { get; set; }

    public long? Iconnum { get; set; }

    public long? Bitmapnum { get; set; }
}
