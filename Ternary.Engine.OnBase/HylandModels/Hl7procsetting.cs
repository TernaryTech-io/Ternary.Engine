using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7procsetting
{
    public long Schedtasknum { get; set; }

    public long? Port { get; set; }

    public string? Hostname { get; set; }

    public string? Hl7certthumbprint { get; set; }

    public long? Flags { get; set; }
}
