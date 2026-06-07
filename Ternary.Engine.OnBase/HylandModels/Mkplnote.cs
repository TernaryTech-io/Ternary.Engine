using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplnote
{
    public long Mkplnotenum { get; set; }

    public long? Usernum { get; set; }

    public string? Mkplnotetitle { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Mkplnotetype { get; set; }

    public string? Mkplnotetext { get; set; }

    public long? Flags { get; set; }
}
