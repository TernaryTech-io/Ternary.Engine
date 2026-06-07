using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Licensedproductcontrol
{
    public string? Licensehash { get; set; }

    public string? Combinedhash { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? Lastupdatever { get; set; }

    public long? Lastupdatetype { get; set; }

    public long? Enctype { get; set; }

    public long? Licensecount { get; set; }

    public long? Flags { get; set; }
}
