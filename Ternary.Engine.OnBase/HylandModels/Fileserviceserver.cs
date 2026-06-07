using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fileserviceserver
{
    public long Servernum { get; set; }

    public string? Serveraddress { get; set; }

    public long? Serverport { get; set; }

    public long? Flags { get; set; }

    public string? Prettyservername { get; set; }

    public string? Encryptkeydata { get; set; }
}
