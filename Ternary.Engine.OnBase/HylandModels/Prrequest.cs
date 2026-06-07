using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prrequest
{
    public long Requestnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Repositorynum { get; set; }

    public long? Recordtype { get; set; }

    public long? Pending { get; set; }

    public DateTime? Requestdate { get; set; }

    public DateTime? Daterequired { get; set; }

    public long? Requestingusernum { get; set; }

    public string? Reasonforrequest { get; set; }

    public long? Urgent { get; set; }

    public long? Delivmethodnum { get; set; }

    public string? Delivinstructions { get; set; }

    public string? Pruniqueid { get; set; }

    public long? Numberofdays { get; set; }
}
