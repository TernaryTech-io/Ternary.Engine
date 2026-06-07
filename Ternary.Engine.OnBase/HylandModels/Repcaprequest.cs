using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repcaprequest
{
    public long Rcrequestnum { get; set; }

    public long? Rcbatchnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Rcstate { get; set; }

    public long? Status { get; set; }

    public long? Extsystemnum { get; set; }

    public string? Rcimportername { get; set; }

    public long? Extdoccount { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Lastmodified { get; set; }

    public string? Rcextuser { get; set; }

    public long? Createdusernum { get; set; }

    public long? Lastmodifiedusernum { get; set; }

    public long? Availabilityid { get; set; }

    public long? Useractionid { get; set; }

    public string? Changereason { get; set; }

    public long? Rcdeleted { get; set; }

    public long? Facilitynum { get; set; }
}
