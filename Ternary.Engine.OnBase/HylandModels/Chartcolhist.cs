using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartcolhist
{
    public long Chtnum { get; set; }

    public long Fieldnum { get; set; }

    public long Charthistsetnum { get; set; }

    public long? Oldfkeyval { get; set; }

    public string? Oldstrval { get; set; }

    public DateTime? Datechanged { get; set; }
}
