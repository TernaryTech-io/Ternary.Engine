using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mppatientlist
{
    public long Patlistnum { get; set; }

    public string? Patlistname { get; set; }

    public long? Patlisttype { get; set; }

    public long? Usernum { get; set; }

    public long? Ispublic { get; set; }
}
