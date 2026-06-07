using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obxmlformat
{
    public long Xmlformatnum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Ediname { get; set; }

    public string? Xmldateformat { get; set; }

    public long? Filetypenum { get; set; }
}
