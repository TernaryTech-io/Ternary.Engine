using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Folderhold
{
    public long? Foldernum { get; set; }

    public long? Usernum { get; set; }

    public long? Holdreasonnum { get; set; }

    public DateTime? Holdtime { get; set; }

    public string? Additionaldesc { get; set; }
}
