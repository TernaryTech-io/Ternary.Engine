using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmotpsection
{
    public long Sectionid { get; set; }

    public long? Applicationid { get; set; }

    public long? Changedflags { get; set; }

    public long? Createdfromid { get; set; }

    public long? Enabled { get; set; }

    public long? Filterid { get; set; }

    public DateTime? Lastsynch { get; set; }

    public DateTime? Lastupdated { get; set; }

    public long? Nosynchchecks { get; set; }

    public long? Sectiontype { get; set; }

    public long? Sequenceid { get; set; }

    public string? Rmtitle { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }
}
