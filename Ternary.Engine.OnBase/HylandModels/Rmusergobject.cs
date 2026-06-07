using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmusergobject
{
    public long Usergobjectid { get; set; }

    public long? Rights { get; set; }

    public long? Rmobjectkey { get; set; }

    public long? Rmobjecttype { get; set; }

    public long? Usergroupnum { get; set; }
}
