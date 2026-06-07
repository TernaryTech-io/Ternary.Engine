using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmuseruisetting
{
    public long Useruiid { get; set; }

    public long? Setting { get; set; }

    public long? Usernum { get; set; }

    public string? Value { get; set; }

    public long? Flags { get; set; }
}
