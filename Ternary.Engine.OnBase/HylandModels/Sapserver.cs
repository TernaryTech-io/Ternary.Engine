using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapserver
{
    public long Sapservernum { get; set; }

    public string? Aliasname { get; set; }

    public string? Sapserveraddress { get; set; }

    public long? Flags { get; set; }
}
