using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Midtermunclaimedtempfile
{
    public long Id { get; set; }

    public string Guid { get; set; } = null!;

    public long Namespaceid { get; set; }

    public long Storagesystemid { get; set; }

    public DateTimeOffset Expiration { get; set; }

    public virtual Namespace Namespace { get; set; } = null!;

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
