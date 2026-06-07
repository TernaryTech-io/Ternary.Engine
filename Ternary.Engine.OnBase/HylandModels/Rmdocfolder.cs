using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmdocfolder
{
    public long Docfolderid { get; set; }

    public long? Classid { get; set; }

    public string? Foldername { get; set; }

    public long? Keymapid { get; set; }

    public long? Sequenceid { get; set; }

    public long? Flags { get; set; }

    public long? Rmdescriptionid { get; set; }

    public long? Universaldocsource { get; set; }
}
