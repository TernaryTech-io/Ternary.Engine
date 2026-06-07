using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obgexamtype
{
    public long Examtypenum { get; set; }

    public string? Reportheader { get; set; }

    public long? Flags { get; set; }

    public string? Description { get; set; }

    public long? Isobexamtype { get; set; }
}
