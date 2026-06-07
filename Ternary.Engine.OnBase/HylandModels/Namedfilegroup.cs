using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Namedfilegroup
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Namespaceid { get; set; }

    public DateTimeOffset Expiration { get; set; }

    public byte[]? Rowversion { get; set; }

    public virtual ICollection<Namedfile> Namedfiles { get; set; } = new List<Namedfile>();

    public virtual ICollection<Namedfilesinprogress> Namedfilesinprogresses { get; set; } = new List<Namedfilesinprogress>();

    public virtual Namespace Namespace { get; set; } = null!;
}
