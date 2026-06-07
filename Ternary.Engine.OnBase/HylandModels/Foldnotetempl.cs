using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldnotetempl
{
    public long Foldnotetplnum { get; set; }

    public string? Foldnotetplname { get; set; }

    public long? Notecolor { get; set; }

    public long? Iconnum { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Creatorusernum { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Flags { get; set; }
}
