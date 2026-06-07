using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amdocgentemplate
{
    public long Docgennum { get; set; }

    public string? Docgenname { get; set; }

    public string? Docgenstylesheet { get; set; }

    public long? Itemnum { get; set; }

    public long? Flags { get; set; }

    public long? Docgentype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Filetypenum { get; set; }

    public string? Fileextension { get; set; }

    public string? Amfilepath { get; set; }
}
