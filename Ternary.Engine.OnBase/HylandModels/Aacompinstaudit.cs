using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aacompinstaudit
{
    public long? Masterauditnum { get; set; }

    public long? Aacompinstnum { get; set; }

    public long? Aacomponentnum { get; set; }

    public string? Instancename { get; set; }

    public long? Instancestatus { get; set; }

    public long? Appservercompinstnum { get; set; }

    public long? Dbconnectiontype { get; set; }

    public string? Location { get; set; }

    public long? Locationtype { get; set; }

    public long? Aadbconnectnum { get; set; }

    public long? Communicationflags { get; set; }

    public long? Heartbeatsec { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public long? Flags { get; set; }
}
