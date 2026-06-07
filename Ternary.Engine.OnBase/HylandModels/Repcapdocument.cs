using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repcapdocument
{
    public long Rcdocumentnum { get; set; }

    public long? Rcrequestnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Rcextdoctype { get; set; }

    public long? Status { get; set; }

    public long? Filetypenum { get; set; }

    public string? Rcfilepath { get; set; }

    public long? Itemnum { get; set; }

    public long? Itemrevisionnum { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Createdusernum { get; set; }

    public long? Lastmodifiedusernum { get; set; }

    public long? Availabilityid { get; set; }

    public long? Processnum { get; set; }

    public long? Useractionid { get; set; }

    public string? Changereason { get; set; }

    public long? Rcdeleted { get; set; }
}
