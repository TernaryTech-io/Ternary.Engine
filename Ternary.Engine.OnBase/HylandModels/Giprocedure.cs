using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giprocedure
{
    public long Giprocedurenum { get; set; }

    public long? Chtnum { get; set; }

    public long? Maxrptrevnum { get; set; }

    public DateTime? Proceduredate { get; set; }

    public long? Giproctypenum { get; set; }

    public long? Flags { get; set; }

    public string? Visitnumber { get; set; }

    public long? Status { get; set; }

    public string? Inscompanyid { get; set; }

    public string? Inscompanyname { get; set; }
}
