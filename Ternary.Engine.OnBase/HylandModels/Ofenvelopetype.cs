using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ofenvelopetype
{
    public long Ofenvelopetypenum { get; set; }

    public string? Oraclesid { get; set; }

    public string? Oracleform { get; set; }

    public string? Oracleblock { get; set; }

    public long? Defaultdoctype { get; set; }

    public long? Dynamicfoldernum { get; set; }

    public long? Flags { get; set; }
}
