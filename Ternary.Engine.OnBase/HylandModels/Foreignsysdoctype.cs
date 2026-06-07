using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foreignsysdoctype
{
    public long Hl7processnum { get; set; }

    public string Hl7doccode { get; set; } = null!;

    public long Itemtypenum { get; set; }

    public long? Filetypenum { get; set; }
}
