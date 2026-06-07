using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entitydataset
{
    public long Etdatasetnum { get; set; }

    public string? Etdatasetname { get; set; }

    public string? Etdescription { get; set; }

    public long? Flags { get; set; }

    public string? Etparentname { get; set; }

    public long? Etsecurevalues { get; set; }

    public string? Etschemaname { get; set; }

    public long? Etvisibility { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
