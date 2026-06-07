using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Payeelineconfig
{
    public string Accountnum { get; set; } = null!;

    public string Abanumber { get; set; } = null!;

    public long? Payeeleft { get; set; }

    public long? Payeeright { get; set; }

    public long? Payeetop { get; set; }

    public long? Payeebottom { get; set; }

    public long? Configtype { get; set; }

    public long? Itemnum { get; set; }

    public long? Origwidth { get; set; }

    public long? Origheight { get; set; }

    public string? Minserial { get; set; }

    public string? Maxserial { get; set; }

    public long? Imageprocess1 { get; set; }

    public long? Imageprocess2 { get; set; }

    public long? Imageprocess3 { get; set; }

    public string? Anchortext { get; set; }

    public long? Createdusernum { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Lastmodifieduser { get; set; }

    public DateTime? Lastmodifieddate { get; set; }
}
