using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amvoteauth
{
    public string? Authtoken { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Expirationtime { get; set; }
}
