using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnaimage
{
    public long Vnaimagenum { get; set; }

    public long? Vnaseriesnum { get; set; }

    public string? Vnaimageuid { get; set; }

    public string? Dicomsopclassuid { get; set; }

    public string? Dicomtransfersyntax { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public string? Hashvalue { get; set; }

    public long? Dicominstancenum { get; set; }
}
