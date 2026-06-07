using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplactivity
{
    public long Mkplactnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Duedate { get; set; }

    public long? Status { get; set; }

    public string? Mkplacttitle { get; set; }

    public long? Relateditemnum { get; set; }

    public long? Flags { get; set; }
}
