using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmpartial
{
    public long Partialid { get; set; }

    public string? Partialname { get; set; }

    public string? Rmdescription { get; set; }

    public long? Sourceid { get; set; }

    public long? Sourcetype { get; set; }

    public long? Flags { get; set; }
}
