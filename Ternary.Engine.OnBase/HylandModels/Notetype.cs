using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notetype
{
    public long Notetypenum { get; set; }

    public string? Notetypename { get; set; }

    public string? Autonamestring { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Notecolor { get; set; }

    public long? Notedisplayflag { get; set; }

    public long? Noteflavor { get; set; }

    public string? Defaultnotetext { get; set; }

    public long? Sanntype { get; set; }

    public long? Fontnum { get; set; }

    public long? Linewidth { get; set; }

    public long? Linestyle { get; set; }

    public long? Switchnotetypenum { get; set; }

    public long? Createshortcutkey { get; set; }
}
