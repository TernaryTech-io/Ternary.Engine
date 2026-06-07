using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsaccount
{
    public long Rsaccountnum { get; set; }

    public string? Rsaccountname { get; set; }

    public decimal? Currentppbalance { get; set; }

    public decimal? Minimumppbalance { get; set; }

    public decimal? Currentinvbalance { get; set; }

    public decimal? Notificationlevel { get; set; }

    public long? Defaultpaytype { get; set; }

    public long? Overdrawallowed { get; set; }

    public string? Financeacctcode { get; set; }

    public string? Treasureracctcode { get; set; }

    public long? Accountaddrnum { get; set; }

    public long? Serviceclassnum { get; set; }

    public long? Active { get; set; }
}
