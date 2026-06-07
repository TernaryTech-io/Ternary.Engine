using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schevent
{
    public long Eventnum { get; set; }

    public string? Eventname { get; set; }

    public long? Eventxdates { get; set; }

    public long? Eventxforce { get; set; }

    public long? Eventxhour { get; set; }

    public long? Eventxmin { get; set; }

    public long? Lastexecd { get; set; }

    public long? Eventflags { get; set; }

    public long? Expiretime { get; set; }

    public string? Semaphorepath { get; set; }
}
