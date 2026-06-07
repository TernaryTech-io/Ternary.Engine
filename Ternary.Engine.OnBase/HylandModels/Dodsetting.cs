using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dodsetting
{
    public long Dodsitenum { get; set; }

    public long? Institution { get; set; }

    public string? Dodbasesite { get; set; }

    public string? Dodsubsite { get; set; }

    public string? Locationslistname { get; set; }

    public string? Ruleslistname { get; set; }

    public string? Rulefieldtype { get; set; }

    public long? Flags { get; set; }
}
