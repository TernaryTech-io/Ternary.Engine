using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinsetting
{
    public long Rcmtwfinsetnum { get; set; }

    public string? Arbatchnoprefix { get; set; }

    public long? Fintypemasternum { get; set; }

    public long? Rcmzerobatchamount { get; set; }

    public long? Rcmeobcount { get; set; }

    public long? Rcmenumlockboxdate { get; set; }

    public long? Rcmenumprocessdate { get; set; }

    public long? Rcmrangelockboxdate { get; set; }

    public long? Rcmrangeprocessdate { get; set; }

    public long? Rcmfacilityfromlockbox { get; set; }

    public long? Rcmcoversheetchecksum { get; set; }

    public long? Rcmenabledetails { get; set; }
}
