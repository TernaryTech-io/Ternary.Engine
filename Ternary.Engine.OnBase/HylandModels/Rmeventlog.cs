using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmeventlog
{
    public long Eventid { get; set; }

    public DateTime? Eventdate { get; set; }

    public string? Eventdescription { get; set; }

    public long? Eventtype { get; set; }

    public long? Objectid { get; set; }

    public long? Transactionid { get; set; }

    public string? Username { get; set; }

    public long? Classid { get; set; }

    public long? Usernum { get; set; }
}
