using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bannertable
{
    public long Bannernum { get; set; }

    public string? Bannername { get; set; }

    public string? Bannerdesc { get; set; }

    public long? Institution { get; set; }

    public long? Bannertype { get; set; }

    public long? Customernum { get; set; }

    public string? Siteid { get; set; }

    public string? Bankid { get; set; }

    public long? Lockboxnum { get; set; }

    public long? Dateflag { get; set; }

    public DateTime? Startdatetime { get; set; }

    public DateTime? Stopdatetime { get; set; }

    public long? Status { get; set; }

    public long? Bannerpriority { get; set; }
}
