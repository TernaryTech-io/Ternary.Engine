using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrpatientevent
{
    public long Mrpatienteventnum { get; set; }

    public string? Mrptcorrelationid { get; set; }

    public long? Usernum { get; set; }

    public long? Mrptclient { get; set; }

    public string? Mrptagentaddress { get; set; }

    public string? Mrptsourceaddress { get; set; }

    public DateTimeOffset? Logdateoffset { get; set; }

    public long? Mrpteventtype { get; set; }

    public long? Mrptoutcome { get; set; }
}
