using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tenantsetting
{
    public long Id { get; set; }

    public long? Storagesystemid { get; set; }

    public long? Cachestoragesystemid { get; set; }

    public long? Midtermstoragesystemid { get; set; }

    public long? Activekekid { get; set; }

    public virtual Kek? Activekek { get; set; }

    public virtual Storagesystem? Cachestoragesystem { get; set; }

    public virtual Storagesystem? Midtermstoragesystem { get; set; }

    public virtual Storagesystem? Storagesystem { get; set; }
}
