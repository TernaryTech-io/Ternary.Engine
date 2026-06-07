using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repcapbatch
{
    public long Rcbatchnum { get; set; }

    public string? Extbatchid { get; set; }

    public string? Rcsourcename { get; set; }

    public long? Rcstate { get; set; }

    public long? Status { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Rcextuser { get; set; }

    public long? Usernum { get; set; }

    public long? Availabilityid { get; set; }

    public long? Useractionid { get; set; }

    public long? Lastmodifiedusernum { get; set; }

    public string? Changereason { get; set; }

    public long? Donotpurgercbatch { get; set; }

    public long? Rcdeleted { get; set; }
}
