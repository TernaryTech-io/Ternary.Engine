using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doclock
{
    public long? Itemnum { get; set; }

    public DateTime? Datelocked { get; set; }

    public long? Usernum { get; set; }

    public long? Foldernum { get; set; }

    public long? Lockreason { get; set; }
}
