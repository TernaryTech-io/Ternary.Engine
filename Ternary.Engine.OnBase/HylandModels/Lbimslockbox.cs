using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimslockbox
{
    public long Datafileversion { get; set; }

    public long Lockboxnum { get; set; }

    public string? Lockboxname { get; set; }

    public long? Customernum { get; set; }

    public long? Lockboxtype { get; set; }

    public long? Imssiteid { get; set; }

    public long? Reportitemtypenum { get; set; }

    public long? Usergroupnum { get; set; }
}
