using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Idpclient
{
    public long Idpclientnum { get; set; }

    public string? Idpclientid { get; set; }

    public long? Obblobnum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }
}
