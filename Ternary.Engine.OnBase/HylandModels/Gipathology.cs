using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gipathology
{
    public long Gipathologynum { get; set; }

    public long? Gireportnum { get; set; }

    public long? Status { get; set; }

    public string? Giordercode { get; set; }

    public string? Giorderdescription { get; set; }

    public DateTime? Orderdate { get; set; }

    public long? Flags { get; set; }

    public long? Itemnum { get; set; }

    public long? Rptrevnum { get; set; }

    public long? Docrevnum { get; set; }
}
