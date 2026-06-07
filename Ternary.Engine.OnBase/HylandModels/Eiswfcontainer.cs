using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eiswfcontainer
{
    public long Wfcontainernum { get; set; }

    public long? Wfcontainritemnum { get; set; }

    public long? Flags { get; set; }

    public string? Contname { get; set; }

    public long? Contitemtypenum { get; set; }
}
