using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmloggingtoken
{
    public long? Usernum { get; set; }

    public long? Authornum { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Duration { get; set; }

    public string? Hashcode { get; set; }

    public long? Tokentype { get; set; }

    public long? Flags { get; set; }

    public DateTime? Expiredate { get; set; }
}
