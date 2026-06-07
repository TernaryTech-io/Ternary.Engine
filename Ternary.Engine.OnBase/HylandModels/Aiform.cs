using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aiform
{
    public long Aiformnum { get; set; }

    public string? Aiformname { get; set; }

    public long? Aitrainingjobnum { get; set; }

    public long? Stddev { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Sampledocid { get; set; }

    public long? Doccount { get; set; }

    public string? Centerdef { get; set; }

    public long? Status { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Createdusernum { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
