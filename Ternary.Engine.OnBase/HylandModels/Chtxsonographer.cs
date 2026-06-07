using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtxsonographer
{
    public long Chtnum { get; set; }

    public long Sonousernum { get; set; }

    public long? Priority { get; set; }

    public long? Flags { get; set; }
}
