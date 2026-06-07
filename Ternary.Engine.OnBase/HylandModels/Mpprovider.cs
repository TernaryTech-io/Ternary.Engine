using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpprovider
{
    public long Mpprovidernum { get; set; }

    public string? Mpprovidername { get; set; }

    public string? Mpauthname { get; set; }

    public string? Mppassword { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }

    public long? Mpvendor { get; set; }

    public string? Mpserviceaddress { get; set; }

    public long? Flags { get; set; }
}
