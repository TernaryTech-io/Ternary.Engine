using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externaldbconfig
{
    public long Externaldbcfgnum { get; set; }

    public string? Odbcdatasource { get; set; }

    public string? Extschema { get; set; }

    public string? Extusername { get; set; }

    public string? Extpassword { get; set; }

    public long? Extsystemnum { get; set; }

    public string? Externaldbname { get; set; }

    public long? Externaldbcfgtype { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
