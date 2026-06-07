using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkpltemplate
{
    public long Mkpltemplatenum { get; set; }

    public string? Mkpltemplatetitle { get; set; }

    public string? Mkpltemplatesubj { get; set; }

    public string? Mkplmessagetext { get; set; }

    public long? Flags { get; set; }
}
