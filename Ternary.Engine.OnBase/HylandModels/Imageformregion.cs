using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Imageformregion
{
    public long Imageformregnum { get; set; }

    public string? Regionname { get; set; }

    public long? Regiontype { get; set; }

    public long? Regionflags { get; set; }

    public long? Regioncoordx { get; set; }

    public long? Regioncoordy { get; set; }

    public long? Regionlen { get; set; }

    public long? Regionwid { get; set; }

    public long? Formatdatanum { get; set; }

    public string? Formatdatakey { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Imageformrevnum { get; set; }

    public long? Regionresetblob { get; set; }
}
