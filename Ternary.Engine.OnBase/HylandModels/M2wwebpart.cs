using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wwebpart
{
    public long Webpartnum { get; set; }

    public long? Webparttypecode { get; set; }

    public string? Webpartname { get; set; }

    public string? Webpartdescription { get; set; }

    public string? Webparttitle { get; set; }

    public string? Webpartheight { get; set; }

    public string? Webpartwidth { get; set; }

    public string? Tooltip { get; set; }

    public long? Refreshinterval { get; set; }

    public string? Errormsg { get; set; }

    public string? Skin { get; set; }

    public long? Flags { get; set; }
}
