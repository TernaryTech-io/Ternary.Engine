using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbuserprivilege
{
    public string Externaluserid { get; set; } = null!;

    public long Lockboxnum { get; set; }

    public long? Userprivilege0 { get; set; }
}
