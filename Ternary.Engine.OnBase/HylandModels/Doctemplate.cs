using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctemplate
{
    public long Doctemplatenum { get; set; }

    public string? Doctemplatename { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Flags { get; set; }
}
