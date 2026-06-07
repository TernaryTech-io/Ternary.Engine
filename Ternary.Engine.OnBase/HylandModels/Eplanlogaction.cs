using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanlogaction
{
    public long Eplogactionnum { get; set; }

    public string? Epactionname { get; set; }

    public long? Eplogactiontype { get; set; }

    public long? Epsubactiontype { get; set; }

    public long? Hide { get; set; }
}
