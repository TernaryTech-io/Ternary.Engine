using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wkstmonitor
{
    public long? Workstationnum { get; set; }

    public long? Wkstprocessid { get; set; }

    public string? Wkstprocessrole { get; set; }

    public string? Wkstprocessname { get; set; }

    public string? Wkstmachinename { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public string? Appdomainname { get; set; }

    public long? Appdomainid { get; set; }

    public string? Wkstosname { get; set; }

    public long? Wkstprocesstime { get; set; }

    public long? Wkstthreadcount { get; set; }

    public long? Wkstmemsize { get; set; }

    public long? Isx64proc { get; set; }

    public long? Isx64machine { get; set; }

    public string? Identityname { get; set; }

    public string? Friendlyname { get; set; }

    public string? Datasourcename { get; set; }

    public string? Buildversion { get; set; }

    public long? Firstchancecount { get; set; }

    public long? Unhandledcount { get; set; }

    public long? Wkstresetcache { get; set; }

    public long? Flags { get; set; }

    public long Wkstentrynum { get; set; }

    public long? Wkstparententrynum { get; set; }
}
