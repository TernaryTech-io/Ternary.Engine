using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmobjecthistory
{
    public long Transactionid { get; set; }

    public long? Attributeid { get; set; }

    public string? Endvalue { get; set; }

    public long? Objectid { get; set; }

    public string? Startvalue { get; set; }

    public DateTime? Transactiondate { get; set; }

    public string? Username { get; set; }

    public long? Classid { get; set; }

    public long? Usernum { get; set; }
}
