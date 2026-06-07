using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanfiledesc
{
    public long Scanfilenum { get; set; }

    public string? Scanfilename { get; set; }

    public long? Barcodetype { get; set; }

    public long? Barsizex { get; set; }

    public long? Barsizey { get; set; }

    public string? Ciddatamatch { get; set; }

    public long? Ciddeltax { get; set; }

    public long? Ciddeltay { get; set; }

    public long? Cidtopx { get; set; }

    public long? Cidtopy { get; set; }

    public long? Commonidflags { get; set; }

    public long? Density { get; set; }

    public long? Diskgroupnum { get; set; }

    public string? Filename { get; set; }

    public long? Interpretbarcode { get; set; }

    public long? Inuse { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Maxbarcodesline { get; set; }

    public long? Maxbarcodespage { get; set; }

    public long? Mincharsincode { get; set; }

    public long? Processtype { get; set; }

    public long? Quality { get; set; }

    public long? Scanmethod { get; set; }

    public long? Searchdirection { get; set; }

    public long? Skewness { get; set; }

    public long? Verychecksum { get; set; }
}
