using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldertype
{
    public long Foldertypenum { get; set; }

    public string? Foldertypename { get; set; }

    public long? Prntfoldertypenum { get; set; }

    public long? Subfolders { get; set; }

    public string? Autonamestring { get; set; }

    public long? Foldertypeflags { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Keysettablenum { get; set; }

    public long? Keygrouptablenum { get; set; }

    public long? Ordercolumn { get; set; }

    public long? Foldercolor { get; set; }

    public string? Reservename { get; set; }

    public string? Newtemplate { get; set; }

    public long? Templatenum { get; set; }

    public long? Intervalflags { get; set; }

    public long? Folderorder { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags2 { get; set; }

    public long? Cqnum { get; set; }

    public long? Mincharspopup { get; set; }

    public long? Noteorder { get; set; }
}
