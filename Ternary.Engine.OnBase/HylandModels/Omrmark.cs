using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Omrmark
{
    public long Omrmarknum { get; set; }

    public long? Omrnum { get; set; }

    public string? Omrmarkname { get; set; }

    public long? Omrmarktype { get; set; }

    public long? Rowpos { get; set; }

    public long? Columnpos { get; set; }

    public long? Markflags { get; set; }

    public long? Wasmin { get; set; }

    public long? Wasmax { get; set; }

    public long? Wasflag { get; set; }

    public long? Wasbitcount { get; set; }

    public long? Parentmark { get; set; }

    public long? Divertcount { get; set; }

    public long? Wasstart { get; set; }

    public string? Statictext { get; set; }
}
