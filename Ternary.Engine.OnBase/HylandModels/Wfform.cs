using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfform
{
    public long Formnum { get; set; }

    public string? Formname { get; set; }

    public long? Itemnum { get; set; }

    public string? Pathtofile { get; set; }

    public long? Flags { get; set; }

    public long? Scope { get; set; }

    public long? Configversion { get; set; }
}
