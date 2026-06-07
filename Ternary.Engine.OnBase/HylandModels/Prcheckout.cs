using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prcheckout
{
    public long Checkoutnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Checkedout { get; set; }

    public long? Checkoutusernum { get; set; }

    public DateTime? Datecheckedout { get; set; }

    public long? Posessionusernum { get; set; }

    public DateTime? Expectreturndate { get; set; }

    public long? Checkinusernum { get; set; }

    public DateTime? Datecheckedin { get; set; }

    public string? Reasonforrequest { get; set; }

    public string? Pruniqueid { get; set; }

    public long? Delivmethodnum { get; set; }
}
