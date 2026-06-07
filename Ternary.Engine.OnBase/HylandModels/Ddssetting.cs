using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ddssetting
{
    public long? Discoverytimeout { get; set; }

    public long? Discoveryretries { get; set; }

    public long? Discoverymethod { get; set; }

    public long? Nonpersistentconn { get; set; }

    public string? Encryptkeydata { get; set; }
}
