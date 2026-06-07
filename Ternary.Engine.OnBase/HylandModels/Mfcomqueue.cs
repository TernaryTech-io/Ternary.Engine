using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfcomqueue
{
    public long Mfnum { get; set; }

    public DateTime? Mfdateprocessed { get; set; }

    public DateTime? Mfdatedown { get; set; }

    public string? Mffilename { get; set; }

    public long? Mfflag { get; set; }

    public string? Mfpath { get; set; }

    public long? Mftype { get; set; }
}
