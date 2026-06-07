using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portfoliorelmapping
{
    public long Portfoliorelnum { get; set; }

    public long Sourcemappingtype { get; set; }

    public long Sourcemappingid { get; set; }

    public string? Sourcemappingvalue { get; set; }

    public long Destmappingtype { get; set; }

    public long Destmappingid { get; set; }

    public long? Flags { get; set; }

    public string Destmappingvalue { get; set; } = null!;

    public long? Constraintoperator { get; set; }

    public long? Numleftparens { get; set; }

    public long? Numrightparens { get; set; }

    public long? Connector { get; set; }

    public long? Seqnum { get; set; }
}
