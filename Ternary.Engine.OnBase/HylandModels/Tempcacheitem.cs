using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tempcacheitem
{
    public long Tempcacheitemnum { get; set; }

    public string? Originalfilename { get; set; }

    public string? Fullfilepath { get; set; }

    public long? Tempcachenum { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Flags { get; set; }

    public long? Keyidentifier { get; set; }
}
