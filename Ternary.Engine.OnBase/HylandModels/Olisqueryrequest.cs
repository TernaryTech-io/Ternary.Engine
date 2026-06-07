using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olisqueryrequest
{
    public long Olisquerynum { get; set; }

    public long? Olissessionnum { get; set; }

    public string? Olispatientid { get; set; }

    public string? Patientidtypecode { get; set; }

    public string? Jurisdictionid { get; set; }

    public string? Jurisdictiontext { get; set; }

    public string? Idtypecode { get; set; }

    public string? Ptlastname { get; set; }

    public string? Ptfirstname { get; set; }

    public string? Ptmiddlename { get; set; }

    public long? Ptsex { get; set; }

    public DateTime? Ptdob { get; set; }

    public DateTime? Querybegintime { get; set; }

    public DateTime? Queryendtime { get; set; }

    public long? Status { get; set; }

    public long? Overridereason { get; set; }

    public string? Overridecomment { get; set; }
}
