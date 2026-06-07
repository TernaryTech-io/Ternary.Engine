using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gihl7obtermconfig
{
    public long Obtermnum { get; set; }

    public string? Obtermcode { get; set; }

    public string? Obtermdescription { get; set; }

    public long? Gidatatypeid { get; set; }

    public long? Flags { get; set; }

    public long? Giproctypenum { get; set; }
}
