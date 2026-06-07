using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsstudioexecaudit
{
    public long Tpsstudioexecnum { get; set; }

    public long? Usernum { get; set; }

    public long? Tpsregnum { get; set; }

    public string? Lockvalue { get; set; }

    public DateTime? Datecreated { get; set; }

    public string? Defxml { get; set; }

    public long? Destreg { get; set; }
}
