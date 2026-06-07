using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pritemlocation
{
    public long Itemnum { get; set; }

    public long? Repositorynum { get; set; }

    public string? Pruniqueid { get; set; }

    public string? Contentsdesc { get; set; }

    public string? Locationdesc { get; set; }

    public string? Sublocation1 { get; set; }

    public string? Sublocation2 { get; set; }

    public string? Sublocation3 { get; set; }

    public string? Sublocation4 { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public long? Prrecordtypenum { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Prcomment { get; set; }

    public long? Volumenumber { get; set; }

    public long? Prstatus { get; set; }
}
