using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalsystem
{
    public long Extsystemnum { get; set; }

    public string? Extsystemname { get; set; }

    public long? Invocationtype { get; set; }

    public long? Extsystemflags { get; set; }

    public long? Extsystemtype { get; set; }
}
