using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ivusersetting
{
    public long Usernum { get; set; }

    public string? Configxml { get; set; }

    public long? Defaultviewtype { get; set; }
}
