using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Endorsersetting
{
    public long Scanformatnum { get; set; }

    public long? Autoendorse { get; set; }

    public long? Autoannotate { get; set; }

    public long? Manualendorse { get; set; }

    public long? Startnumber { get; set; }

    public long? Startnumdigit { get; set; }

    public long? Incmode { get; set; }

    public long? Inconpage { get; set; }

    public long? Inconpatch { get; set; }

    public long? Incvalue { get; set; }

    public long? Skipfirstpatch { get; set; }

    public long? Resetmode { get; set; }

    public long? Resetonpage { get; set; }

    public long? Resetonpatch { get; set; }

    public long? Resetvalue { get; set; }

    public long? Fontorientation { get; set; }

    public long? Fonttype { get; set; }

    public long? Textoffsetleft { get; set; }

    public long? Textoffsettop { get; set; }

    public string? Endorseprefix { get; set; }
}
