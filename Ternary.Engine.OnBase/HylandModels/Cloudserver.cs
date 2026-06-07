using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cloudserver
{
    public long Cloudservernum { get; set; }

    public string? Cloudservername { get; set; }

    public long? Cloudservertype { get; set; }

    public string? Cloudserverurl { get; set; }

    public long? Flags { get; set; }

    public string? Clouduser { get; set; }

    public string? Cloudpassword { get; set; }

    public DateTime? Lastheartbeat { get; set; }
}
