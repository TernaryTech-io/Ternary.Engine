using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wdlock
{
    public long? Itemnum { get; set; }

    public string? Wdtoken { get; set; }

    public long? Lockshared { get; set; }

    public long? Deep { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Usernum { get; set; }

    public string? Wdhandlername { get; set; }
}
