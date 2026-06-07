using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Kwmergejob
{
    public long Kwmergejobnum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }
}
