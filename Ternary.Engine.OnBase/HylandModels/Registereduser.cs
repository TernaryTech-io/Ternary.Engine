using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Registereduser
{
    public long Registernum { get; set; }

    public string? Registername { get; set; }

    public DateTime? Dateregistered { get; set; }

    public string? Networkid { get; set; }

    public long? Pcserialnum { get; set; }

    public long? Usernum { get; set; }

    public string? Stationdesc { get; set; }

    public long? Wkstationgrpnum { get; set; }

    public long? Cachenum { get; set; }

    public string? Macaddress { get; set; }

    public DateTime? Lastlogon { get; set; }

    public long? Badlogincount { get; set; }

    public string? Machineid { get; set; }

    public long? Platformtype { get; set; }

    public long? Machineidtype { get; set; }

    public long? Flags { get; set; }
}
