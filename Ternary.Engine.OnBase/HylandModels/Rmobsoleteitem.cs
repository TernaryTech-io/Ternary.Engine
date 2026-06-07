using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmobsoleteitem
{
    public long Obsoleteitemid { get; set; }

    public long? Obsoleteitemtype { get; set; }

    public long? Objectkey { get; set; }

    public long? Objecttype { get; set; }

    public long? Parentid { get; set; }

    public long? Flags { get; set; }
}
