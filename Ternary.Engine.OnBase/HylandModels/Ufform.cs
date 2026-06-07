using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufform
{
    public long Ufformnum { get; set; }

    public string? Formname { get; set; }

    public long? Maxrevnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Ufformtype { get; set; }

    public long? Flags { get; set; }

    public long? Dstype { get; set; }

    public long? Primarylcid { get; set; }

    public string? Localename { get; set; }

    public long? Formstatus { get; set; }
}
