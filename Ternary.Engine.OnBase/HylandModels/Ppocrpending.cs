using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ppocrpending
{
    public long Ppjobnum { get; set; }

    public long? Registernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itemrange { get; set; }

    public string? Outputpath { get; set; }

    public long? Flags { get; set; }

    public string? Inputroot { get; set; }
}
