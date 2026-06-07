using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Serveroption
{
    public long Registernum { get; set; }

    public long Servertype { get; set; }

    public long? Serverflags1 { get; set; }

    public long? Serverflags2 { get; set; }

    public long? Notifyflags { get; set; }

    public string? Notifyaddress { get; set; }
}
