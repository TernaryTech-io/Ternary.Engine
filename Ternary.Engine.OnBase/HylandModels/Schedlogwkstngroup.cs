using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedlogwkstngroup
{
    public long Wkstngroupnum { get; set; }

    public string? Groupname { get; set; }

    public long? Detaillevel { get; set; }

    public long? Retaindays { get; set; }

    public long? Flags { get; set; }
}
