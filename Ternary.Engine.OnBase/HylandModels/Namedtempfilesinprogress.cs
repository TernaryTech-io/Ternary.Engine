using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Namedtempfilesinprogress
{
    public long Id { get; set; }

    public long Namedfileinprogressid { get; set; }

    public string Guid { get; set; } = null!;

    public long Storagesystemid { get; set; }

    public long? Multipartuploadid { get; set; }

    public virtual Multipartupload? Multipartupload { get; set; }

    public virtual Namedfilesinprogress Namedfileinprogress { get; set; } = null!;

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
