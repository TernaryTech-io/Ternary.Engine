using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Namedfile
{
    public long Id { get; set; }

    public long Filegroupid { get; set; }

    public string Name { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public long Storagesystemid { get; set; }

    public virtual Namedfilegroup Filegroup { get; set; } = null!;

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
