using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aierpsystem
{
    public long Aierpnum { get; set; }

    public long? Institution { get; set; }

    public string? Aierpname { get; set; }

    public long? Ailayoutupdate { get; set; }

    public string? Aggregateguid { get; set; }

    public long? Flags { get; set; }

    public DateTime? Updatetimestamp { get; set; }

    public long? Aicapconfignum { get; set; }
}
