using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aicapconfig
{
    public long Aicapconfignum { get; set; }

    public string? Aicapconfigname { get; set; }

    public long? Aicapconfigtype { get; set; }

    public long? Aicapconfiglevel { get; set; }

    public long? Obblobnum { get; set; }

    public string? Aggregateguid { get; set; }
}
