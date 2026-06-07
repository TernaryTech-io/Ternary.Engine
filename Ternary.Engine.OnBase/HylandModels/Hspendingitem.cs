using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hspendingitem
{
    public long? Objectid { get; set; }

    public long? Providertype { get; set; }

    public long? Hscatalognum { get; set; }

    public long? Handlertype { get; set; }

    public long? Handlerauxid { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Workstationnum { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public long? Revisionnum { get; set; }

    public long? Filetypenum { get; set; }

    public string? Workstationname { get; set; }
}
