using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rguser
{
    public long Readinggroupnum { get; set; }

    public long Usernum { get; set; }

    public DateTime? Dateactivated { get; set; }

    public DateTime? Datedeactivated { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public long? Groupcount { get; set; }
}
