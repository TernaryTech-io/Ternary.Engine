using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsengineexecaudit
{
    public long Tpsengineexecnum { get; set; }

    public long? Usernum { get; set; }

    public long? Tpsscriptnum { get; set; }

    public long? Tpsstudioexecnum { get; set; }

    public DateTime? Datestart { get; set; }

    public DateTime? Datestop { get; set; }

    public long? Tpsregnum { get; set; }

    public string? Lockvalue { get; set; }
}
