using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Authtoken
{
    public string? Authtokenid { get; set; }

    public long? Sessionid { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Expiredate { get; set; }

    public string? Authprops { get; set; }
}
