using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dbupgradelog
{
    public long Dbupgradenum { get; set; }

    public string? Fromswversion { get; set; }

    public string? Toswversion { get; set; }

    public DateTime? Upgradestarttime { get; set; }

    public DateTime? Upgradeendtime { get; set; }

    public long? Usernum { get; set; }

    public string? Dbusername { get; set; }

    public string? Emailaddress { get; set; }

    public string? Executableversion { get; set; }
}
