using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmask101
{
    public long Maskid { get; set; }

    public string? Maskname { get; set; }

    public string? Description { get; set; }

    public string? Maskpattern { get; set; }

    public string? Maskplaceholder { get; set; }

    public long? Flags { get; set; }
}
