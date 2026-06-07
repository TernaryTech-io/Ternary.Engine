using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnarevision
{
    public long Vnarevnum { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Vnarevdescription { get; set; }

    public long? Flags { get; set; }
}
