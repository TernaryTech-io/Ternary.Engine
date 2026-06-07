using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmigrationactivitylog
{
    public long? Actiontype { get; set; }

    public long? Applicationid { get; set; }

    public string? Datastring { get; set; }

    public long? Logversion { get; set; }

    public long? Objectid { get; set; }

    public long? Objecttype { get; set; }

    public DateTime? Transactiondate { get; set; }

    public long? Transactionid { get; set; }

    public string? Username { get; set; }
}
