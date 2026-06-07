using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gisproxyconfig
{
    public long Gisproxyconfignum { get; set; }

    public long? Gisproxypermisnum { get; set; }

    public string? Proxyurl { get; set; }

    public string? Serviceauthtoken { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Flags { get; set; }
}
