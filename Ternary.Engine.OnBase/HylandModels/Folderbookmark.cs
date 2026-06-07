using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Folderbookmark
{
    public long Foldbookmarknum { get; set; }

    public long? Foldernum { get; set; }

    public long? Notecolor { get; set; }

    public long? Iconnum { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Creatorusernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Notexposcol { get; set; }

    public long? Noteyposrow { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Notetext { get; set; }
}
