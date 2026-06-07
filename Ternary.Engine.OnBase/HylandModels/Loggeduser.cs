using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Loggeduser
{
    public long Usernum { get; set; }

    public long Producttype { get; set; }

    public long Registernum { get; set; }

    public long? Checkin { get; set; }

    public long? Heartbeat { get; set; }

    public long? Numlocks { get; set; }

    public long? Sessionid { get; set; }

    public string? Sessionguid { get; set; }

    public long? Terminalsessionid { get; set; }

    public long? Flags { get; set; }

    public string? Machineid { get; set; }

    public long? Machineidtype { get; set; }
}
