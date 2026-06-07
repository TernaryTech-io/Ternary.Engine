using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Namedfilesinprogress
{
    public long Id { get; set; }

    public long Filegroupid { get; set; }

    public string Name { get; set; } = null!;

    public DateTimeOffset Expiration { get; set; }

    public virtual Namedfilegroup Filegroup { get; set; } = null!;

    public virtual ICollection<Namedtempfilesinprogress> Namedtempfilesinprogresses { get; set; } = new List<Namedtempfilesinprogress>();
}
