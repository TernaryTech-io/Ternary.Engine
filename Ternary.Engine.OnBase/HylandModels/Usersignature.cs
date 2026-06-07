using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usersignature
{
    public long Usernum { get; set; }

    public string? Usersigpassword { get; set; }

    public DateTime? Sigpasschanged { get; set; }

    public long? Sigbitmapnum { get; set; }

    public long? Initialbitmapnum { get; set; }

    public long? Sighistoryflags { get; set; }

    public long? Sighistorylen { get; set; }

    public long? Expireflag { get; set; }

    public long? Expirenumber { get; set; }

    public long? Expireuses { get; set; }

    public long? Usageflags { get; set; }

    public long? Usagedayflags { get; set; }

    public DateTime? Usagetimein { get; set; }

    public DateTime? Usagetimeout { get; set; }

    public long? Sigusagecount { get; set; }

    public string? Defaultcert { get; set; }

    public long? Signertype { get; set; }
}
