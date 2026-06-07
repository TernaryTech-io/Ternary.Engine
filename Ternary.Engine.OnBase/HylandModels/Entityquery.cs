using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityquery
{
    public long Entityquerynum { get; set; }

    public long? Entitytypenum { get; set; }

    public string? Etqueryname { get; set; }

    public string? Etdescription { get; set; }

    public long? Flags { get; set; }

    public long? Etvisibility { get; set; }

    public string? Clrassemblyname { get; set; }

    public string? Queryclrtypename { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }

    public string? Etuiparameters { get; set; }

    public string? Etdisplayname { get; set; }
}
