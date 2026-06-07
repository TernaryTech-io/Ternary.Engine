using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Originalfilename
{
    public long Itemnum { get; set; }

    public long Itempagenum { get; set; }

    public long Filetypenum { get; set; }

    public string? Originalfilepath { get; set; }

    public string? Ofilename { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Cadscopenum { get; set; }

    public string? Strippedpath { get; set; }

    public long? Flags { get; set; }
}
