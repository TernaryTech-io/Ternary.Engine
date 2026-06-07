using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uncstoragesystem
{
    public long Storagesystemid { get; set; }

    public string Uncshare { get; set; } = null!;

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
