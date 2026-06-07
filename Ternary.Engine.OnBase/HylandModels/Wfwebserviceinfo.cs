using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfwebserviceinfo
{
    public long Webservicenum { get; set; }

    public string? Webservicename { get; set; }

    public string? Wsdllocation { get; set; }

    public long? Flags { get; set; }
}
