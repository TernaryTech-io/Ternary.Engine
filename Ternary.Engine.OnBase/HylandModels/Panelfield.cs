using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Panelfield
{
    public long Panelnum { get; set; }

    public long Panelfieldnum { get; set; }

    public long? Editxloc { get; set; }

    public long? Edityloc { get; set; }

    public string? Fieldtext { get; set; }

    public long? Fieldtype { get; set; }

    public long Keysetnum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Keyvaluechar { get; set; }

    public long Keywordnum { get; set; }

    public long? Staticxloc { get; set; }

    public long? Staticyloc { get; set; }

    public long? Xsize { get; set; }

    public long? Ysize { get; set; }

    public long? Flags { get; set; }
}
