using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ranote
{
    public long Ranotesnum { get; set; }

    public long? Objectid { get; set; }

    public long? Objecttypeid { get; set; }

    public string? Notetext { get; set; }

    public string? Createusername { get; set; }

    public DateTime? Datecreated { get; set; }
}
