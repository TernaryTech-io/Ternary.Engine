using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Filetype
{
    public long Filetypenum { get; set; }

    public string? Filetypestr { get; set; }

    public string? Extension { get; set; }

    public string? Commandline { get; set; }

    public long? Displaytype { get; set; }

    public long? Printtype { get; set; }

    public long? Filetypeflags { get; set; }

    public string? Mimetype { get; set; }
}
