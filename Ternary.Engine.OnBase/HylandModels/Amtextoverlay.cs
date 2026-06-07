using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amtextoverlay
{
    public long Textoverlaynum { get; set; }

    public string? Overlayname { get; set; }

    public string? Overlaytext { get; set; }

    public long? Overlayencoding { get; set; }

    public long? Overlaytype { get; set; }

    public long? Anchorpoint { get; set; }

    public long? Xoffset { get; set; }

    public long? Yoffset { get; set; }

    public long? Maxwidth { get; set; }

    public string? Fontname { get; set; }

    public long? Fontsize { get; set; }

    public long? Fontcolor { get; set; }

    public long? Fontopacity { get; set; }

    public long? Fontrotation { get; set; }

    public long? Scale { get; set; }

    public long? Flags { get; set; }
}
