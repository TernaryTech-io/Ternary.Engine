using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityresource
{
    public long Etresourcenum { get; set; }

    public string? Etdisplayname { get; set; }

    public string? Etdescription { get; set; }

    public long? Etownertype { get; set; }

    public string? Contenttype { get; set; }

    public string? Entitytext { get; set; }

    public long? Flags { get; set; }

    public long? Etownerid { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
